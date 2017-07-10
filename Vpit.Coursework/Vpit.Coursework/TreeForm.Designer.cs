namespace Vpit.Coursework
{
    partial class TreeForm
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
            this.treeViewList = new System.Windows.Forms.ListView();
            this.databaseTreeViev = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeViewList
            // 
            this.treeViewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.treeViewList.Location = new System.Drawing.Point(438, 2);
            this.treeViewList.Margin = new System.Windows.Forms.Padding(1);
            this.treeViewList.Name = "treeViewList";
            this.treeViewList.Size = new System.Drawing.Size(371, 330);
            this.treeViewList.TabIndex = 4;
            this.treeViewList.UseCompatibleStateImageBehavior = false;
            this.treeViewList.View = System.Windows.Forms.View.Tile;
            // 
            // databaseTreeViev
            // 
            this.databaseTreeViev.Location = new System.Drawing.Point(4, 2);
            this.databaseTreeViev.Margin = new System.Windows.Forms.Padding(1);
            this.databaseTreeViev.Name = "databaseTreeViev";
            this.databaseTreeViev.Size = new System.Drawing.Size(430, 330);
            this.databaseTreeViev.TabIndex = 3;
            this.databaseTreeViev.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.databaseTreeViev_AfterSelect);
            // 
            // TreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 335);
            this.Controls.Add(this.treeViewList);
            this.Controls.Add(this.databaseTreeViev);
            this.Name = "TreeForm";
            this.Text = "TreeForm";
            this.Load += new System.EventHandler(this.TreeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView treeViewList;
        private System.Windows.Forms.TreeView databaseTreeViev;
    }
}