using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Vpit.Coursework
{
    public partial class MainForm : Form
    {
        public DBComands dataBaseCommands;
        public string connectionString;

        public MainForm()
        {
            InitializeComponent();
            dataBaseCommands = new DBComands();
            connectionString = ConfigurationManager.ConnectionStrings["Vpit.Coursework.Properties.Settings.PoliceDbConnectionString"].ConnectionString;

            var tablesNames = new List<string>();

            foreach (var tableName in GetTablesList())
            {
                AddTableToToolStrips(tableName);
            }

        }

        public void AddTableToToolStrips(string tableName)
        {
            openToolStripMenuItem.DropDownItems.Add(tableName);
            deleteTableToolStripMenuItem.DropDownItems.Add(tableName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        void createTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var createTableForm = new CreateTableForm
            {
                MdiParent = this
            };
            createTableForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        public ICollection<string> GetTablesList()
        {
            var tables = new List<string>();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    DataTable dataTabe = connection.GetSchema("Tables");
                    foreach (DataRow row in dataTabe.Rows)
                    {
                        var tablename = (string)row[2];
                        tables.Add(tablename);
                    }
                    connection.Close();
                }
                return tables;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        private void openToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var tableName = e.ClickedItem.Text;

            var tableForm = new TableForm(tableName)
            {
                MdiParent = this,
                Text = tableName + " Table"
            };
            tableForm.Show();

        }

        private void deleteTableToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var tableName = e.ClickedItem.Text;
            dataBaseCommands.DeleteTableComand(tableName);

            openToolStripMenuItem.DropDownItems.Clear();
            deleteTableToolStripMenuItem.DropDownItems.Clear();

            foreach (var table in GetTablesList())
            {
                AddTableToToolStrips(table);
            }
        }

        private void relationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var relationForm = new RelationForm()
            {
                MdiParent = this
            };
            relationForm.Show();
        }

        private void queryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var queryForm = new QueryForm()
            {
                MdiParent = this
            };
            queryForm.Show();
        }

        private void proceduresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proceduresForm = new ProceduresForm()
            {
                MdiParent = this
            };
            proceduresForm.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchForm()
            {
                MdiParent = this
            };
            searchForm.Show();
        }

        private void xmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var xmlForm = new XmlForm()
            {
                MdiParent = this
            };
            xmlForm.Show();
        }

        private void treeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var treeForm = new TreeForm()
            {
                MdiParent = this
            };
            treeForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KPCC VPIT Coursework\n(c) Robert Tsaturyan", "About", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}