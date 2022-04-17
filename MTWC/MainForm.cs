using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MTWC
{
    public partial class MainForm : Form
    {
        private MTWCData _ds;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            gvColGrid.DoubleBuffered(true);
            gvCompare.DoubleBuffered(true);

            _ds = new MTWCData();
            tbLines.Lines = _ds.Lines;
            bsColSelection.DataSource = _ds.ColInfo;
            bsCompareCols.DataSource = _ds.ColInfo;

            foreach (ColInfo info in _ds.DefaultCols())
            {
                lbCols.SelectedItems.Add(info);
            }

            tbRowFilter.Text = "";
            _ds.SetShownRows(_ds.DefaultRows);
            PopulateRows();
            bsCompareRows.DataSource = _ds.ShownRows();
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

            foreach (var row in _ds.FilterRows(tbRowFilter.Text))
            {
                lbRows.Items.Add(row);
                if (row._compare)
                {
                    lbRows.SelectedItems.Add(row);
                }
            }

            lbRows.SelectedIndexChanged += new EventHandler(lbRows_SelectedIndexChanged);
            lbRows.EndUpdate();
        }

        private void lbRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ds.SetShownRows(lbRows.SelectedItems);
            bsCompareRows.DataSource = _ds.ShownRows();
        }
    }
}