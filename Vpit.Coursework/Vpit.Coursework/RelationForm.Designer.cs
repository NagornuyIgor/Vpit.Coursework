namespace Vpit.Coursework
{
    partial class RelationForm
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
            this.firstTableComboBox = new System.Windows.Forms.ComboBox();
            this.secondTableComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstTableColumnsListBox = new System.Windows.Forms.ListBox();
            this.secondTableColumnsListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.createRelationButton = new System.Windows.Forms.Button();
            this.deleteRelationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstTableComboBox
            // 
            this.firstTableComboBox.FormattingEnabled = true;
            this.firstTableComboBox.Location = new System.Drawing.Point(12, 38);
            this.firstTableComboBox.Name = "firstTableComboBox";
            this.firstTableComboBox.Size = new System.Drawing.Size(200, 21);
            this.firstTableComboBox.TabIndex = 0;
            this.firstTableComboBox.SelectedIndexChanged += new System.EventHandler(this.firstTableComboBox_SelectedIndexChanged);
            // 
            // secondTableComboBox
            // 
            this.secondTableComboBox.FormattingEnabled = true;
            this.secondTableComboBox.Location = new System.Drawing.Point(272, 38);
            this.secondTableComboBox.Name = "secondTableComboBox";
            this.secondTableComboBox.Size = new System.Drawing.Size(200, 21);
            this.secondTableComboBox.TabIndex = 1;
            this.secondTableComboBox.SelectedIndexChanged += new System.EventHandler(this.secondTableComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(69, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(313, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Second Table";
            // 
            // firstTableColumnsListBox
            // 
            this.firstTableColumnsListBox.FormattingEnabled = true;
            this.firstTableColumnsListBox.Location = new System.Drawing.Point(12, 87);
            this.firstTableColumnsListBox.Name = "firstTableColumnsListBox";
            this.firstTableColumnsListBox.Size = new System.Drawing.Size(200, 173);
            this.firstTableColumnsListBox.TabIndex = 4;
            // 
            // secondTableColumnsListBox
            // 
            this.secondTableColumnsListBox.FormattingEnabled = true;
            this.secondTableColumnsListBox.Location = new System.Drawing.Point(270, 87);
            this.secondTableColumnsListBox.Name = "secondTableColumnsListBox";
            this.secondTableColumnsListBox.Size = new System.Drawing.Size(202, 173);
            this.secondTableColumnsListBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(328, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Columns";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(69, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Columns";
            // 
            // createRelationButton
            // 
            this.createRelationButton.Location = new System.Drawing.Point(73, 266);
            this.createRelationButton.Name = "createRelationButton";
            this.createRelationButton.Size = new System.Drawing.Size(75, 40);
            this.createRelationButton.TabIndex = 8;
            this.createRelationButton.Text = "Create Relation";
            this.createRelationButton.UseVisualStyleBackColor = true;
            this.createRelationButton.Click += new System.EventHandler(this.createRelationButton_Click);
            // 
            // deleteRelationButton
            // 
            this.deleteRelationButton.Location = new System.Drawing.Point(332, 266);
            this.deleteRelationButton.Name = "deleteRelationButton";
            this.deleteRelationButton.Size = new System.Drawing.Size(75, 40);
            this.deleteRelationButton.TabIndex = 9;
            this.deleteRelationButton.Text = "Delete Relation";
            this.deleteRelationButton.UseVisualStyleBackColor = true;
            this.deleteRelationButton.Click += new System.EventHandler(this.deleteRelationButton_Click);
            // 
            // RelationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 313);
            this.Controls.Add(this.deleteRelationButton);
            this.Controls.Add(this.createRelationButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secondTableColumnsListBox);
            this.Controls.Add(this.firstTableColumnsListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondTableComboBox);
            this.Controls.Add(this.firstTableComboBox);
            this.Name = "RelationForm";
            this.Text = "RelationForm";
            this.Load += new System.EventHandler(this.RelationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox firstTableComboBox;
        private System.Windows.Forms.ComboBox secondTableComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox firstTableColumnsListBox;
        private System.Windows.Forms.ListBox secondTableColumnsListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createRelationButton;
        private System.Windows.Forms.Button deleteRelationButton;
    }
}