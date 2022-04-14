﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MTWC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        MTWCData _main;

        const string RowDefault = "^spearmen|viking|housecarle";

        static readonly ColType[] ColDefault = new ColType[] {
            ColType.UnitId, ColType.SupportCost, ColType.ProductionCost,
            ColType.UnitSize,

            ColType.Region, ColType.RegionIDtroopAdvantage,
            ColType.RulerIDTroopAdvantage,
            ColType.FactionAssociation, ColType.BuildingsNeeded,
            
            ColType.MeleeSupportingRanks,
            ColType.CavAttackBonus,
            ColType.CavDefenceBonus,

            ColType.MoralBonus,
            ColType.IsArmourPiercing,
            ColType.ShieldType,
            ColType.ShieldModifier,

            ColType.RUN_SPEED, ColType.CHARGE_BONUS,
            ColType.MELEE_BONUS, ColType.DEFENCE_BONUS, ColType.ARMOUR_LEVEL
        };

        private void MainForm_Load(object sender, EventArgs e)
        {
            gvColGrid.DoubleBuffered(true);
            gvCompare.DoubleBuffered(true);

            _main = new MTWCData();
            tbLines.Lines = _main.Lines;
            bsColSelection.DataSource = _main.ColInfo;
            bsCompareCols.DataSource = _main.ColInfo;

            var selectedCols = _main.ColInfo.Where(c => ColDefault.Any(d => d == c.Type));
            foreach (ColInfo info in selectedCols)
            {
                lbCols.SelectedItems.Add(info);
            }
            tbRowFilter.Text = "";
            SetDefaultRowSelection();
            PopulateRows();
            bsCompareRows.DataSource = GetSelectedRows();
        }

        private void lbCols_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCols = new List<string>();
            foreach (ColInfo info in lbCols.SelectedItems)
            {
                selectedCols.Add(info.Type.ToString());
            }

            foreach (DataGridViewColumn col in gvCompare.Columns)
            {
                col.Visible = selectedCols.Count == 0
                    || selectedCols.Contains(col.HeaderText)
                    || col.HeaderText == ColType.UnitId.ToString()
                    || col.HeaderText == "#";
            }
        }

        private void gvCompare_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var ds = (List<RowInfo>)bsCompareRows.DataSource;
            var name = gvCompare.Columns[e.ColumnIndex].HeaderText;

            var sortProp = typeof(RowInfo).GetProperty(name);

            if (sortProp.PropertyType == typeof(int?))
            {
                ds.Sort((x, y) =>
                {
                    var xx = sortProp.GetValue(x) as int?;
                    var yy = sortProp.GetValue(y) as int?;

                    var result = xx == null
                        ? yy == null ? 0 : 1
                        : yy == null ? -1 : (int)yy - (int)xx;
                    return result;
                });
            }
            else
            {
                ds.Sort((x, y) =>
                {
                    var xx = sortProp.GetValue(x).ToString();
                    var yy = sortProp.GetValue(y).ToString();

                    var result = string.IsNullOrWhiteSpace(xx)
                        ? string.IsNullOrWhiteSpace(yy) ? 0 : 1
                        : string.IsNullOrWhiteSpace(yy) ? -1 : xx.CompareTo(yy);
                    return result;
                });
            }

            gvCompare.Refresh();
        }

        private void tbRows_TextChanged(object sender, EventArgs e)
        {
            PopulateRows();
        }

        private void PopulateRows()
        {
            lbRows.BeginUpdate();
            lbRows.SelectedIndexChanged -= new EventHandler(lbRows_SelectedIndexChanged);
            lbRows.Items.Clear();

            foreach (var row in GetFilteredRows(tbRowFilter.Text))
            {
                lbRows.Items.Add(row);
                if (row._show)
                {
                    lbRows.SelectedItems.Add(row);
                }
            }

            lbRows.SelectedIndexChanged += new EventHandler(lbRows_SelectedIndexChanged);
            lbRows.EndUpdate();
        }

        private List<RowInfo> GetFilteredRows(string filter)
        {
            var search = filter.Trim() ?? "";
            if (search == "") return _main.RowInfo;
            var regex = new Regex(search, RegexOptions.IgnoreCase);
            return _main.RowInfo.FindAll(r => regex.IsMatch(r.UnitId));
        }

        private List<RowInfo> GetSelectedRows()
        {
            return _main.RowInfo.Where(r => r._show).ToList();
        }

        private void SetDefaultRowSelection()
        {
            foreach (var row in _main.RowInfo)
            {
                row._show = false;
            }
            foreach (var row in GetFilteredRows(RowDefault))
            {
                row._show = true;
            }
        }

        private void lbRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            var showAll = lbRows.SelectedItems.Count == 0;
            foreach (RowInfo row in _main.RowInfo)
            {
                row._show = showAll;
            }
            foreach (RowInfo row in lbRows.SelectedItems)
            {
                row._show = true;
            }
            bsCompareRows.DataSource = GetSelectedRows();
        }
    }
}