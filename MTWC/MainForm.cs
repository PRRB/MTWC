using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace MTWC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Main _main;

        const string RowDefault = "light";

        static readonly ColType[] ColDefault = new ColType[]
            {ColType.UnitId, ColType.SupportCost, ColType.ProductionCost,
                ColType.UnitSize,
             ColType.MoralBonus, ColType.RUN_SPEED, ColType.CHARGE_BONUS,
             ColType.MELEE_BONUS, ColType.DEFENCE_BONUS, ColType.ARMOUR_LEVEL};

        private void MainForm_Load(object sender, EventArgs e)
        {
            _main = new Main();
            tbLines.Lines = _main.Lines;
            colInfoBindingSource.DataSource = _main.ColInfo;

            var selectedCols = _main.ColInfo.Where(c => ColDefault.Any(d => d == c.Type));
            foreach (ColInfo info in selectedCols)
            {
                lbCols.SelectedItems.Add(info);
            }
            tbRows.Text = RowDefault;
            SetDefaultRowSelection();
            PopulateRows();
            rowInfoBindingSource.DataSource = GetSelectedRows();
        }

        private void lbCols_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCols = new List<string>();
            foreach (ColInfo info in lbCols.SelectedItems)
            {
                selectedCols.Add(info.Type.ToString());
            }

            foreach (DataGridViewColumn col in gvRowGrid.Columns)
            {
                col.Visible = selectedCols.Count == 0
                    || selectedCols.Contains(col.HeaderText)
                    || col.HeaderText == ColType.UnitId.ToString()
                    || col.HeaderText == "#";
            }
        }

        private void gvRowGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gvRowGrid.Sort(gvRowGrid.Columns[e.ColumnIndex], ListSortDirection.Ascending);
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

            foreach (var row in GetFilteredRows())
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

        private List<RowInfo> GetFilteredRows()
        {
            var search = (tbRows.Text ?? "").ToLower();
            return _main.RowInfo
                .FindAll(r => search == "" || r.UnitId.ToLower().Contains(search));
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
            foreach (var row in GetFilteredRows())
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
            rowInfoBindingSource.DataSource = GetSelectedRows();
        }
    }
}
