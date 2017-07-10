namespace Vpit.Coursework
{
    partial class QueryForm
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
            this.queryDataGridView = new System.Windows.Forms.DataGridView();
            this.queryComboBox = new System.Windows.Forms.ComboBox();
            this.executeQueryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.queryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // queryDataGridView
            // 
            this.queryDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.queryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryDataGridView.Location = new System.Drawing.Point(12, 52);
            this.queryDataGridView.Name = "queryDataGridView";
            this.queryDataGridView.Size = new System.Drawing.Size(664, 250);
            this.queryDataGridView.TabIndex = 14;
            // 
            // queryComboBox
            // 
            this.queryComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.queryComboBox.FormattingEnabled = true;
            this.queryComboBox.Location = new System.Drawing.Point(12, 16);
            this.queryComboBox.Name = "queryComboBox";
            this.queryComboBox.Size = new System.Drawing.Size(350, 27);
            this.queryComboBox.TabIndex = 13;
            // 
            // executeQueryButton
            // 
            this.executeQueryButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.executeQueryButton.Location = new System.Drawing.Point(576, 16);
            this.executeQueryButton.Name = "executeQueryButton";
            this.executeQueryButton.Size = new System.Drawing.Size(100, 30);
            this.executeQueryButton.TabIndex = 12;
            this.executeQueryButton.Text = "Execute";
            this.executeQueryButton.UseVisualStyleBackColor = true;
            this.executeQueryButton.Click += new System.EventHandler(this.executeQueryButton_Click);
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 312);
            this.Controls.Add(this.queryDataGridView);
            this.Controls.Add(this.queryComboBox);
            this.Controls.Add(this.executeQueryButton);
            this.Name = "QueryForm";
            this.Text = "queryForm";
            this.Load += new System.EventHandler(this.QueryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.queryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView queryDataGridView;
        private System.Windows.Forms.ComboBox queryComboBox;
        private System.Windows.Forms.Button executeQueryButton;
    }
}