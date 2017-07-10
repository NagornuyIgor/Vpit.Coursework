namespace Vpit.Coursework
{
    partial class ProceduresForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.deleteParameterProcedureButton = new System.Windows.Forms.Button();
            this.executeParameterProcedureButton = new System.Windows.Forms.Button();
            this.createParameterProcedureButton = new System.Windows.Forms.Button();
            this.ParameterTextBox = new System.Windows.Forms.TextBox();
            this.columnNameComboBox = new System.Windows.Forms.ComboBox();
            this.paramTableNameComboBox = new System.Windows.Forms.ComboBox();
            this.procedureDataGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableNameComboBox = new System.Windows.Forms.ComboBox();
            this.deleteProcedureButton = new System.Windows.Forms.Button();
            this.executeProcedureButton = new System.Windows.Forms.Button();
            this.createProcedureButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.parameterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.procedureDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(428, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 19);
            this.label7.TabIndex = 32;
            // 
            // deleteParameterProcedureButton
            // 
            this.deleteParameterProcedureButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteParameterProcedureButton.Location = new System.Drawing.Point(512, 346);
            this.deleteParameterProcedureButton.Name = "deleteParameterProcedureButton";
            this.deleteParameterProcedureButton.Size = new System.Drawing.Size(100, 30);
            this.deleteParameterProcedureButton.TabIndex = 31;
            this.deleteParameterProcedureButton.Text = "Delete";
            this.deleteParameterProcedureButton.UseVisualStyleBackColor = true;
            this.deleteParameterProcedureButton.Click += new System.EventHandler(this.deleteParameterProcedureButton_Click);
            // 
            // executeParameterProcedureButton
            // 
            this.executeParameterProcedureButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.executeParameterProcedureButton.Location = new System.Drawing.Point(512, 306);
            this.executeParameterProcedureButton.Name = "executeParameterProcedureButton";
            this.executeParameterProcedureButton.Size = new System.Drawing.Size(100, 30);
            this.executeParameterProcedureButton.TabIndex = 30;
            this.executeParameterProcedureButton.Text = "Execute";
            this.executeParameterProcedureButton.UseVisualStyleBackColor = true;
            this.executeParameterProcedureButton.Click += new System.EventHandler(this.executeParameterProcedureButton_Click);
            // 
            // createParameterProcedureButton
            // 
            this.createParameterProcedureButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createParameterProcedureButton.Location = new System.Drawing.Point(512, 266);
            this.createParameterProcedureButton.Name = "createParameterProcedureButton";
            this.createParameterProcedureButton.Size = new System.Drawing.Size(100, 30);
            this.createParameterProcedureButton.TabIndex = 29;
            this.createParameterProcedureButton.Text = "Create";
            this.createParameterProcedureButton.UseVisualStyleBackColor = true;
            this.createParameterProcedureButton.Click += new System.EventHandler(this.createParameterProcedureButton_Click);
            // 
            // ParameterTextBox
            // 
            this.ParameterTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParameterTextBox.Location = new System.Drawing.Point(304, 308);
            this.ParameterTextBox.Name = "ParameterTextBox";
            this.ParameterTextBox.Size = new System.Drawing.Size(176, 26);
            this.ParameterTextBox.TabIndex = 28;
            // 
            // columnNameComboBox
            // 
            this.columnNameComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnNameComboBox.FormattingEnabled = true;
            this.columnNameComboBox.Location = new System.Drawing.Point(158, 307);
            this.columnNameComboBox.Name = "columnNameComboBox";
            this.columnNameComboBox.Size = new System.Drawing.Size(140, 27);
            this.columnNameComboBox.TabIndex = 27;
            this.columnNameComboBox.SelectedIndexChanged += new System.EventHandler(this.columnNameComboBox_SelectedIndexChanged);
            // 
            // paramTableNameComboBox
            // 
            this.paramTableNameComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paramTableNameComboBox.FormattingEnabled = true;
            this.paramTableNameComboBox.Location = new System.Drawing.Point(12, 306);
            this.paramTableNameComboBox.Name = "paramTableNameComboBox";
            this.paramTableNameComboBox.Size = new System.Drawing.Size(140, 27);
            this.paramTableNameComboBox.TabIndex = 26;
            this.paramTableNameComboBox.SelectedIndexChanged += new System.EventHandler(this.paramTableNameComboBox_SelectedIndexChanged);
            // 
            // procedureDataGridView
            // 
            this.procedureDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.procedureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.procedureDataGridView.Location = new System.Drawing.Point(12, 90);
            this.procedureDataGridView.Name = "procedureDataGridView";
            this.procedureDataGridView.Size = new System.Drawing.Size(600, 160);
            this.procedureDataGridView.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(300, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Parameter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(154, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Column name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Table name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(151, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Procedure with paramters";
            // 
            // tableNameComboBox
            // 
            this.tableNameComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableNameComboBox.FormattingEnabled = true;
            this.tableNameComboBox.Location = new System.Drawing.Point(417, 54);
            this.tableNameComboBox.Name = "tableNameComboBox";
            this.tableNameComboBox.Size = new System.Drawing.Size(139, 27);
            this.tableNameComboBox.TabIndex = 38;
            // 
            // deleteProcedureButton
            // 
            this.deleteProcedureButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteProcedureButton.Location = new System.Drawing.Point(224, 54);
            this.deleteProcedureButton.Name = "deleteProcedureButton";
            this.deleteProcedureButton.Size = new System.Drawing.Size(100, 30);
            this.deleteProcedureButton.TabIndex = 37;
            this.deleteProcedureButton.Text = "Delete";
            this.deleteProcedureButton.UseVisualStyleBackColor = true;
            this.deleteProcedureButton.Click += new System.EventHandler(this.deleteProcedureButton_Click);
            // 
            // executeProcedureButton
            // 
            this.executeProcedureButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.executeProcedureButton.Location = new System.Drawing.Point(118, 54);
            this.executeProcedureButton.Name = "executeProcedureButton";
            this.executeProcedureButton.Size = new System.Drawing.Size(100, 30);
            this.executeProcedureButton.TabIndex = 36;
            this.executeProcedureButton.Text = "Execute";
            this.executeProcedureButton.UseVisualStyleBackColor = true;
            this.executeProcedureButton.Click += new System.EventHandler(this.executeProcedureButton_Click);
            // 
            // createProcedureButton
            // 
            this.createProcedureButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createProcedureButton.Location = new System.Drawing.Point(12, 54);
            this.createProcedureButton.Name = "createProcedureButton";
            this.createProcedureButton.Size = new System.Drawing.Size(100, 30);
            this.createProcedureButton.TabIndex = 35;
            this.createProcedureButton.Text = "Create";
            this.createProcedureButton.UseVisualStyleBackColor = true;
            this.createProcedureButton.Click += new System.EventHandler(this.createProcedureButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(333, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "Table name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Procedure without paramters";
            // 
            // parameterLabel
            // 
            this.parameterLabel.AutoSize = true;
            this.parameterLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parameterLabel.Location = new System.Drawing.Point(365, 288);
            this.parameterLabel.Name = "parameterLabel";
            this.parameterLabel.Size = new System.Drawing.Size(103, 19);
            this.parameterLabel.TabIndex = 39;
            this.parameterLabel.Text = "Choose column";
            // 
            // ProceduresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 379);
            this.Controls.Add(this.parameterLabel);
            this.Controls.Add(this.tableNameComboBox);
            this.Controls.Add(this.deleteProcedureButton);
            this.Controls.Add(this.executeProcedureButton);
            this.Controls.Add(this.createProcedureButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deleteParameterProcedureButton);
            this.Controls.Add(this.executeParameterProcedureButton);
            this.Controls.Add(this.createParameterProcedureButton);
            this.Controls.Add(this.ParameterTextBox);
            this.Controls.Add(this.columnNameComboBox);
            this.Controls.Add(this.paramTableNameComboBox);
            this.Controls.Add(this.procedureDataGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "ProceduresForm";
            this.Text = "ProceduresForm";
            this.Load += new System.EventHandler(this.ProceduresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.procedureDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button deleteParameterProcedureButton;
        private System.Windows.Forms.Button executeParameterProcedureButton;
        private System.Windows.Forms.Button createParameterProcedureButton;
        private System.Windows.Forms.TextBox ParameterTextBox;
        private System.Windows.Forms.ComboBox columnNameComboBox;
        private System.Windows.Forms.ComboBox paramTableNameComboBox;
        private System.Windows.Forms.DataGridView procedureDataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tableNameComboBox;
        private System.Windows.Forms.Button deleteProcedureButton;
        private System.Windows.Forms.Button executeProcedureButton;
        private System.Windows.Forms.Button createProcedureButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label parameterLabel;
    }
}