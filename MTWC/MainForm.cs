using System;
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

        private void colInfoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
