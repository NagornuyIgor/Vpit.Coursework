namespace Vpit.Coursework
{
    partial class XmlForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.secondXmlTable = new System.Windows.Forms.DataGridView();
            this.firstXmlTable = new System.Windows.Forms.DataGridView();
            this.columnsListBox = new System.Windows.Forms.ListBox();
            this.tablesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstDvgTable = new System.Windows.Forms.DataGridView();
            this.fillFirstTableButton = new System.Windows.Forms.Button();
            this.createFirstTableButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fillSecondTableButton = new System.Windows.Forms.Button();
            this.createSecondTableButton = new System.Windows.Forms.Button();
            this.secondDvgTable = new System.Windows.Forms.DataGridView();
            this.readXmlButton = new System.Windows.Forms.Button();
            this.saveXmlButton = new System.Windows.Forms.Button();
            this.createRelationshipButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.secondXmlTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstXmlTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstDvgTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondDvgTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(553, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Прочитаное из Xml";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(445, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Table 2 ";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lable.Location = new System.Drawing.Point(445, 53);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(54, 19);
            this.lable.TabIndex = 7;
            this.lable.Text = "Table 1";
            // 
            // secondXmlTable
            // 
            this.secondXmlTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.secondXmlTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.secondXmlTable.Location = new System.Drawing.Point(440, 313);
            this.secondXmlTable.Name = "secondXmlTable";
            this.secondXmlTable.Size = new System.Drawing.Size(400, 150);
            this.secondXmlTable.TabIndex = 6;
            // 
            // firstXmlTable
            // 
            this.firstXmlTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstXmlTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.firstXmlTable.Location = new System.Drawing.Point(440, 82);
            this.firstXmlTable.Name = "firstXmlTable";
            this.firstXmlTable.Size = new System.Drawing.Size(400, 150);
            this.firstXmlTable.TabIndex = 5;
            // 
            // columnsListBox
            // 
            this.columnsListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnsListBox.FormattingEnabled = true;
            this.columnsListBox.ItemHeight = 19;
            this.columnsListBox.Location = new System.Drawing.Point(711, 469);
            this.columnsListBox.Name = "columnsListBox";
            this.columnsListBox.Size = new System.Drawing.Size(120, 80);
            this.columnsListBox.TabIndex = 11;
            // 
            // tablesComboBox
            // 
            this.tablesComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tablesComboBox.FormattingEnabled = true;
            this.tablesComboBox.Location = new System.Drawing.Point(584, 469);
            this.tablesComboBox.Name = "tablesComboBox";
            this.tablesComboBox.Size = new System.Drawing.Size(121, 27);
            this.tablesComboBox.TabIndex = 10;
            this.tablesComboBox.SelectedIndexChanged += new System.EventHandler(this.tablesComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Create table 1";
            // 
            // firstDvgTable
            // 
            this.firstDvgTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstDvgTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.firstDvgTable.Location = new System.Drawing.Point(12, 82);
            this.firstDvgTable.Name = "firstDvgTable";
            this.firstDvgTable.Size = new System.Drawing.Size(400, 150);
            this.firstDvgTable.TabIndex = 14;
            // 
            // fillFirstTableButton
            // 
            this.fillFirstTableButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fillFirstTableButton.Location = new System.Drawing.Point(292, 42);
            this.fillFirstTableButton.Name = "fillFirstTableButton";
            this.fillFirstTableButton.Size = new System.Drawing.Size(100, 30);
            this.fillFirstTableButton.TabIndex = 13;
            this.fillFirstTableButton.Text = "Fill";
            this.fillFirstTableButton.UseVisualStyleBackColor = true;
            this.fillFirstTableButton.Click += new System.EventHandler(this.fillFirstTableButton_Click);
            // 
            // createFirstTableButton
            // 
            this.createFirstTableButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createFirstTableButton.Location = new System.Drawing.Point(42, 42);
            this.createFirstTableButton.Name = "createFirstTableButton";
            this.createFirstTableButton.Size = new System.Drawing.Size(100, 30);
            this.createFirstTableButton.TabIndex = 12;
            this.createFirstTableButton.Text = "Create";
            this.createFirstTableButton.UseVisualStyleBackColor = true;
            this.createFirstTableButton.Click += new System.EventHandler(this.createFirstTableButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(158, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Create table 2";
            // 
            // fillSecondTableButton
            // 
            this.fillSecondTableButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fillSecondTableButton.Location = new System.Drawing.Point(292, 276);
            this.fillSecondTableButton.Name = "fillSecondTableButton";
            this.fillSecondTableButton.Size = new System.Drawing.Size(100, 30);
            this.fillSecondTableButton.TabIndex = 18;
            this.fillSecondTableButton.Text = "Fill";
            this.fillSecondTableButton.UseVisualStyleBackColor = true;
            this.fillSecondTableButton.Click += new System.EventHandler(this.fillSecondTableButton_Click);
            // 
            // createSecondTableButton
            // 
            this.createSecondTableButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createSecondTableButton.Location = new System.Drawing.Point(42, 276);
            this.createSecondTableButton.Name = "createSecondTableButton";
            this.createSecondTableButton.Size = new System.Drawing.Size(100, 30);
            this.createSecondTableButton.TabIndex = 17;
            this.createSecondTableButton.Text = "Create";
            this.createSecondTableButton.UseVisualStyleBackColor = true;
            this.createSecondTableButton.Click += new System.EventHandler(this.createSecondTableButton_Click);
            // 
            // secondDvgTable
            // 
            this.secondDvgTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.secondDvgTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.secondDvgTable.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.secondDvgTable.Location = new System.Drawing.Point(12, 313);
            this.secondDvgTable.Name = "secondDvgTable";
            this.secondDvgTable.Size = new System.Drawing.Size(400, 150);
            this.secondDvgTable.TabIndex = 16;
            // 
            // readXmlButton
            // 
            this.readXmlButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readXmlButton.Location = new System.Drawing.Point(268, 469);
            this.readXmlButton.Name = "readXmlButton";
            this.readXmlButton.Size = new System.Drawing.Size(100, 50);
            this.readXmlButton.TabIndex = 22;
            this.readXmlButton.Text = "Read Xml";
            this.readXmlButton.UseVisualStyleBackColor = true;
            this.readXmlButton.Click += new System.EventHandler(this.readXmlButton_Click);
            // 
            // saveXmlButton
            // 
            this.saveXmlButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveXmlButton.Location = new System.Drawing.Point(162, 469);
            this.saveXmlButton.Name = "saveXmlButton";
            this.saveXmlButton.Size = new System.Drawing.Size(100, 50);
            this.saveXmlButton.TabIndex = 21;
            this.saveXmlButton.Text = "Save Xml";
            this.saveXmlButton.UseVisualStyleBackColor = true;
            this.saveXmlButton.Click += new System.EventHandler(this.saveXmlButton_Click);
            // 
            // createRelationshipButton
            // 
            this.createRelationshipButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createRelationshipButton.Location = new System.Drawing.Point(56, 469);
            this.createRelationshipButton.Name = "createRelationshipButton";
            this.createRelationshipButton.Size = new System.Drawing.Size(100, 50);
            this.createRelationshipButton.TabIndex = 20;
            this.createRelationshipButton.Text = "Create Relationship";
            this.createRelationshipButton.UseVisualStyleBackColor = true;
            this.createRelationshipButton.Click += new System.EventHandler(this.createRelationshipButton_Click);
            // 
            // XmlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 561);
            this.Controls.Add(this.readXmlButton);
            this.Controls.Add(this.saveXmlButton);
            this.Controls.Add(this.createRelationshipButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fillSecondTableButton);
            this.Controls.Add(this.createSecondTableButton);
            this.Controls.Add(this.secondDvgTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstDvgTable);
            this.Controls.Add(this.fillFirstTableButton);
            this.Controls.Add(this.createFirstTableButton);
            this.Controls.Add(this.columnsListBox);
            this.Controls.Add(this.tablesComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.secondXmlTable);
            this.Controls.Add(this.firstXmlTable);
            this.Name = "XmlForm";
            this.Text = "XmlForm";
            ((System.ComponentModel.ISupportInitialize)(this.secondXmlTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstXmlTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstDvgTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondDvgTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.DataGridView secondXmlTable;
        private System.Windows.Forms.DataGridView firstXmlTable;
        private System.Windows.Forms.ListBox columnsListBox;
        private System.Windows.Forms.ComboBox tablesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView firstDvgTable;
        private System.Windows.Forms.Button fillFirstTableButton;
        private System.Windows.Forms.Button createFirstTableButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fillSecondTableButton;
        private System.Windows.Forms.Button createSecondTableButton;
        private System.Windows.Forms.DataGridView secondDvgTable;
        private System.Windows.Forms.Button readXmlButton;
        private System.Windows.Forms.Button saveXmlButton;
        private System.Windows.Forms.Button createRelationshipButton;
    }
}