using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MTWC
{
    public partial class MainForm : Form
    {
        private MTWCData _ds;

        public MainForm() => InitializeComponent();

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
            var selectedCols = lbCols
                .SelectedItems
                .Cast<ColInfo>()
                .Select(c => c.Type.ToString());

            foreach (DataGridViewColumn col in gvCompare.Columns)
            {
                col.Visible = !selectedCols.Any()
                    || selectedCols.Contains(col.HeaderText)
                    || col.HeaderText == ColType.UnitId.ToString()
                    || col.HeaderText == "#";
            }
        }

        private void gvCompare_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = (List<RowInfo>)bsCompareRows.DataSource;
            var name = gvCompare.Columns[e.ColumnIndex].HeaderText;

            var sortProp = typeof(RowInfo).GetProperty(name);
            GridHelp.RowSort(row, sortProp);

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
                if (row._isActive)
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