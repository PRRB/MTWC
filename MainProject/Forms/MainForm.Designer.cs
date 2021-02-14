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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpLines = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dsColInfo = new System.Windows.Forms.BindingSource(this.components);
            this.tpColGrid = new System.Windows.Forms.TabPage();
            this.gvColumns = new System.Windows.Forms.DataGridView();
            this.gvcRowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvctypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcgcvtitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcdataTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpCols = new System.Windows.Forms.TabPage();
            this.rtLines = new System.Windows.Forms.RichTextBox();
            this.tpRowGrid = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsRows = new System.Windows.Forms.BindingSource(this.components);
            this.mainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcMain.SuspendLayout();
            this.tpLines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsColInfo)).BeginInit();
            this.tpColGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvColumns)).BeginInit();
            this.tpCols.SuspendLayout();
            this.tpRowGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpLines);
            this.tcMain.Controls.Add(this.tpColGrid);
            this.tcMain.Controls.Add(this.tpCols);
            this.tcMain.Controls.Add(this.tpRowGrid);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(672, 389);
            this.tcMain.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tcMain.TabIndex = 2;
            // 
            // tpLines
            // 
            this.tpLines.Controls.Add(this.listBox1);
            this.tpLines.Location = new System.Drawing.Point(4, 24);
            this.tpLines.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpLines.Name = "tpLines";
            this.tpLines.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpLines.Size = new System.Drawing.Size(664, 361);
            this.tpLines.TabIndex = 2;
            this.tpLines.Text = "Cols";
            this.tpLines.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.dsColInfo;
            this.listBox1.DisplayMember = "Type";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(7, 9);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(524, 334);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "Title";
            // 
            // dsColInfo
            // 
            this.dsColInfo.DataMember = "ColInfo";
            this.dsColInfo.DataSource = typeof(TWCompare.Main);
            // 
            // tpColGrid
            // 
            this.tpColGrid.Controls.Add(this.gvColumns);
            this.tpColGrid.Location = new System.Drawing.Point(4, 24);
            this.tpColGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpColGrid.Name = "tpColGrid";
            this.tpColGrid.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpColGrid.Size = new System.Drawing.Size(664, 361);
            this.tpColGrid.TabIndex = 1;
            this.tpColGrid.Text = "ColGrid";
            this.tpColGrid.UseVisualStyleBackColor = true;
            // 
            // gvColumns
            // 
            this.gvColumns.AllowUserToAddRows = false;
            this.gvColumns.AllowUserToDeleteRows = false;
            this.gvColumns.AllowUserToOrderColumns = true;
            this.gvColumns.AutoGenerateColumns = false;
            this.gvColumns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvColumns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvcRowNum,
            this.gvctypeDataGridViewTextBoxColumn,
            this.gvcgcvtitleDataGridViewTextBoxColumn,
            this.gvcdataTypeDataGridViewTextBoxColumn,
            this.gvcdescriptionDataGridViewTextBoxColumn});
            this.gvColumns.DataSource = this.dsColInfo;
            this.gvColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvColumns.Location = new System.Drawing.Point(4, 3);
            this.gvColumns.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gvColumns.Name = "gvColumns";
            this.gvColumns.ReadOnly = true;
            this.gvColumns.RowHeadersVisible = false;
            this.gvColumns.Size = new System.Drawing.Size(656, 355);
            this.gvColumns.TabIndex = 0;
            // 
            // gvcRowNum
            // 
            this.gvcRowNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gvcRowNum.DataPropertyName = "RowNum";
            this.gvcRowNum.HeaderText = "#";
            this.gvcRowNum.Name = "gvcRowNum";
            this.gvcRowNum.ReadOnly = true;
            this.gvcRowNum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvcRowNum.Width = 39;
            // 
            // gvctypeDataGridViewTextBoxColumn
            // 
            this.gvctypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gvctypeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.gvctypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.gvctypeDataGridViewTextBoxColumn.Name = "gvctypeDataGridViewTextBoxColumn";
            this.gvctypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gvcgcvtitleDataGridViewTextBoxColumn
            // 
            this.gvcgcvtitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gvcgcvtitleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.gvcgcvtitleDataGridViewTextBoxColumn.FillWeight = 248.2759F;
            this.gvcgcvtitleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.gvcgcvtitleDataGridViewTextBoxColumn.Name = "gvcgcvtitleDataGridViewTextBoxColumn";
            this.gvcgcvtitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gvcdataTypeDataGridViewTextBoxColumn
            // 
            this.gvcdataTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gvcdataTypeDataGridViewTextBoxColumn.DataPropertyName = "DataType";
            this.gvcdataTypeDataGridViewTextBoxColumn.FillWeight = 25.86207F;
            this.gvcdataTypeDataGridViewTextBoxColumn.HeaderText = "DataType";
            this.gvcdataTypeDataGridViewTextBoxColumn.Name = "gvcdataTypeDataGridViewTextBoxColumn";
            this.gvcdataTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gvcdescriptionDataGridViewTextBoxColumn
            // 
            this.gvcdescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gvcdescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.gvcdescriptionDataGridViewTextBoxColumn.FillWeight = 25.86207F;
            this.gvcdescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.gvcdescriptionDataGridViewTextBoxColumn.Name = "gvcdescriptionDataGridViewTextBoxColumn";
            this.gvcdescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tpCols
            // 
            this.tpCols.Controls.Add(this.rtLines);
            this.tpCols.Location = new System.Drawing.Point(4, 24);
            this.tpCols.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpCols.Name = "tpCols";
            this.tpCols.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpCols.Size = new System.Drawing.Size(664, 361);
            this.tpCols.TabIndex = 0;
            this.tpCols.Text = "Lines";
            this.tpCols.UseVisualStyleBackColor = true;
            // 
            // rtLines
            // 
            this.rtLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtLines.Location = new System.Drawing.Point(4, 3);
            this.rtLines.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtLines.Name = "rtLines";
            this.rtLines.ReadOnly = true;
            this.rtLines.Size = new System.Drawing.Size(656, 355);
            this.rtLines.TabIndex = 0;
            this.rtLines.Text = "";
            this.rtLines.WordWrap = false;
            // 
            // tpRowGrid
            // 
            this.tpRowGrid.Controls.Add(this.dataGridView1);
            this.tpRowGrid.Location = new System.Drawing.Point(4, 24);
            this.tpRowGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpRowGrid.Name = "tpRowGrid";
            this.tpRowGrid.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpRowGrid.Size = new System.Drawing.Size(664, 361);
            this.tpRowGrid.TabIndex = 3;
            this.tpRowGrid.Text = "RowGrid";
            this.tpRowGrid.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(656, 355);
            this.dataGridView1.TabIndex = 0;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 389);
            this.Controls.Add(this.tcMain);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcMain.ResumeLayout(false);
            this.tpLines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsColInfo)).EndInit();
            this.tpColGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvColumns)).EndInit();
            this.tpCols.ResumeLayout(false);
            this.tpRowGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpCols;
        private System.Windows.Forms.TabPage tpColGrid;
        private System.Windows.Forms.DataGridView gvColumns;
        private System.Windows.Forms.RichTextBox rtLines;
        private System.Windows.Forms.TabPage tpLines;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource dsRows;
        private System.Windows.Forms.BindingSource mainBindingSource;
        private System.Windows.Forms.BindingSource colsBindingSource;
        private System.Windows.Forms.TabPage tpRowGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcRowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvctypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcgcvtitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcdataTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dsColInfo;
    }
}

