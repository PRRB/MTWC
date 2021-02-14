using System;
using System.Windows.Forms;

namespace TWCompare
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Main _main;

        private void MainForm_Load(object sender, EventArgs e)
        {
            _main = new Main();
            this.dsColInfo.DataSource = _main;
            this.dsRows.DataSource = _main;
            richTextBox1.Lines = _main.Lines;
            
        }
    }
}
