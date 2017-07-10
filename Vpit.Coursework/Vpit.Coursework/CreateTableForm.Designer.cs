namespace Vpit.Coursework
{
    partial class CreateTableForm
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
            this.createTableMenuStrip = new System.Windows.Forms.MenuStrip();
            this.addRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTableDataGridView = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tableNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.policeDbDataSet = new Vpit.Coursework.PoliceDbDataSet();
            this.createTableMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.createTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // createTableMenuStrip
            // 
            this.createTableMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRowToolStripMenuItem,
            this.deleteColumnToolStripMenuItem,
            this.saveTableToolStripMenuItem});
            this.createTableMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.createTableMenuStrip.Name = "createTableMenuStrip";
            this.createTableMenuStrip.Size = new System.Drawing.Size(545, 24);
            this.createTableMenuStrip.TabIndex = 1;
            this.createTableMenuStrip.Text = "createTableMenuStrip";
            // 
            // addRowToolStripMenuItem
            // 
            this.addRowToolStripMenuItem.Name = "addRowToolStripMenuItem";
            this.addRowToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.addRowToolStripMenuItem.Text = "Add Column";
            this.addRowToolStripMenuItem.Click += new System.EventHandler(this.addRowToolStripMenuItem_Click);
            // 
            // deleteColumnToolStripMenuItem
            // 
            this.deleteColumnToolStripMenuItem.Name = "deleteColumnToolStripMenuItem";
            this.deleteColumnToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.deleteColumnToolStripMenuItem.Text = "Delete Columns";
            this.deleteColumnToolStripMenuItem.Click += new System.EventHandler(this.deleteColumnToolStripMenuItem_Click);
            // 
            // saveTableToolStripMenuItem
            // 
            this.saveTableToolStripMenuItem.Name = "saveTableToolStripMenuItem";
            this.saveTableToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.saveTableToolStripMenuItem.Text = "Save Table";
            this.saveTableToolStripMenuItem.Click += new System.EventHandler(this.saveTableToolStripMenuItem_Click);
            // 
            // createTableDataGridView
            // 
            this.createTableDataGridView.AllowUserToAddRows = false;
            this.createTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.createTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.dataTypeColumn});
            this.createTableDataGridView.Location = new System.Drawing.Point(0, 27);
            this.createTableDataGridView.Name = "createTableDataGridView";
            this.createTableDataGridView.Size = new System.Drawing.Size(545, 223);
            this.createTableDataGridView.TabIndex = 2;
            // 
            // columnName
            // 
            this.columnName.FillWeight = 250F;
            this.columnName.HeaderText = "Column Name";
            this.columnName.Name = "columnName";
            this.columnName.Width = 350;
            // 
            // dataTypeColumn
            // 
            this.dataTypeColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataTypeColumn.HeaderText = "Type";
            this.dataTypeColumn.Items.AddRange(new object[] {
            "string",
            "int",
            "boolean",
            "char",
            "byte",
            "date time"});
            this.dataTypeColumn.Name = "dataTypeColumn";
            this.dataTypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTypeColumn.Width = 150;
            // 
            // tableNameTextBox
            // 
            this.tableNameTextBox.Location = new System.Drawing.Point(394, 4);
            this.tableNameTextBox.Name = "tableNameTextBox";
            this.tableNameTextBox.Size = new System.Drawing.Size(147, 20);
            this.tableNameTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(323, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Table Name";
            // 
            // policeDbDataSet
            // 
            this.policeDbDataSet.DataSetName = "PoliceDbDataSet";
            this.policeDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CreateTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableNameTextBox);
            this.Controls.Add(this.createTableDataGridView);
            this.Controls.Add(this.createTableMenuStrip);
            this.MainMenuStrip = this.createTableMenuStrip;
            this.Name = "CreateTableForm";
            this.Text = "CreateTableForm";
            this.createTableMenuStrip.ResumeLayout(false);
            this.createTableMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.createTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeDbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip createTableMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteColumnToolStripMenuItem;
        private System.Windows.Forms.DataGridView createTableDataGridView;
        private System.Windows.Forms.TextBox tableNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem saveTableToolStripMenuItem;
        private PoliceDbDataSet policeDbDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataTypeColumn;
    }
}