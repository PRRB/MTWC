namespace TWCompare
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dsColInfo = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tpColGrid = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rowNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsRows = new System.Windows.Forms.BindingSource(this.components);
            this.mainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpRowGrid = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsColInfo)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tpColGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tpColGrid);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tpRowGrid);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(156, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(472, 337);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(464, 311);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cols";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.dsColInfo;
            this.listBox1.DisplayMember = "Type";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 8);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(450, 290);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "Title";
            // 
            // dsColInfo
            // 
            this.dsColInfo.DataMember = "ColInfo";
            this.dsColInfo.DataSource = typeof(TWCompare.Main);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(464, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lines";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(458, 305);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // tpColGrid
            // 
            this.tpColGrid.Controls.Add(this.dataGridView1);
            this.tpColGrid.Location = new System.Drawing.Point(4, 22);
            this.tpColGrid.Name = "tpColGrid";
            this.tpColGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tpColGrid.Size = new System.Drawing.Size(464, 311);
            this.tpColGrid.TabIndex = 1;
            this.tpColGrid.Text = "ColGrid";
            this.tpColGrid.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowNumDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.dataTypeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dsColInfo;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 305);
            this.dataGridView1.TabIndex = 0;
            // 
            // rowNumDataGridViewTextBoxColumn
            // 
            this.rowNumDataGridViewTextBoxColumn.DataPropertyName = "RowNum";
            this.rowNumDataGridViewTextBoxColumn.HeaderText = "RowNum";
            this.rowNumDataGridViewTextBoxColumn.Name = "rowNumDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // dataTypeDataGridViewTextBoxColumn
            // 
            this.dataTypeDataGridViewTextBoxColumn.DataPropertyName = "DataType";
            this.dataTypeDataGridViewTextBoxColumn.HeaderText = "DataType";
            this.dataTypeDataGridViewTextBoxColumn.Name = "dataTypeDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // dsRows
            // 
            this.dsRows.DataMember = "Rows";
            this.dsRows.DataSource = typeof(TWCompare.Main);
            // 
            // mainBindingSource
            // 
            this.mainBindingSource.DataSource = typeof(TWCompare.Main);
            // 
            // colsBindingSource
            // 
            this.colsBindingSource.DataMember = "Cols";
            this.colsBindingSource.DataSource = this.dsRows;
            // 
            // tpRowGrid
            // 
            this.tpRowGrid.Location = new System.Drawing.Point(4, 22);
            this.tpRowGrid.Name = "tpRowGrid";
            this.tpRowGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tpRowGrid.Size = new System.Drawing.Size(464, 311);
            this.tpRowGrid.TabIndex = 3;
            this.tpRowGrid.Text = "RowGrid";
            this.tpRowGrid.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 337);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsColInfo)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tpColGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tpColGrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.BindingSource dsColInfo;
        private System.Windows.Forms.BindingSource dsRows;
        private System.Windows.Forms.BindingSource mainBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource colsBindingSource;
        private System.Windows.Forms.TabPage tpRowGrid;
    }
}

