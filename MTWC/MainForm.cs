using System;
using System.Collections.Generic;
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            _main = new Main();
            this.tbLines.Lines = _main.Lines;
            this.colInfoBindingSource.DataSource = _main.ColInfo;
            this.rowInfoBindingSource.DataSource = _main.RowInfo;
        }

        private void lbCols_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCols = new List<string>();
            foreach (ColInfo info in lbCols.SelectedItems)
            {
                selectedCols.Add(info.Type.ToString());
            }

            foreach (DataGridViewColumn col in this.gvRowGrid.Columns)
            {
                col.Visible = selectedCols.Count == 0 
                    || selectedCols.Contains(col.HeaderText);
            }
        }
    }
}
