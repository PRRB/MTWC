using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;

namespace MTWC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Main _main;

        private void MainForm_Load(object sender, EventArgs e)
        {
            _main = new Main();
            tbLines.Lines = _main.Lines;
            colInfoBindingSource.DataSource = _main.ColInfo;
            rowInfoBindingSource.DataSource = _main.RowInfo;
            PopulateRows();
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

            var search = (tbRows.Text ?? "").ToLower();
            var rows = _main.RowInfo
                .FindAll(r => search == "" || r.UnitId.ToLower().Contains(search));

            foreach (var row in rows)
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

        private void lbRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            var showAll = lbRows.SelectedItems.Count == 0;
            foreach (RowInfo row in _main.RowInfo)
            {
                row._show = showAll;
            }
            if (showAll) return;
            foreach (RowInfo row in lbRows.SelectedItems)
            {
                row._show = true;
            }
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[gvRowGrid.DataSource];
            currencyManager1.SuspendBinding();
            foreach (DataGridViewRow row in gvRowGrid.Rows)
            {
                var rowInfo = (row.DataBoundItem as RowInfo);
                row.Visible = rowInfo._show;
            }
            currencyManager1.ResumeBinding();
        }
    }
}
