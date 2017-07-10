using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Vpit.Coursework
{
    public partial class TreeForm : Form
    {
        SqlConnection connection = new SqlConnection();
        DataSet dataSet = new DataSet();

        public TreeForm()
        {
            InitializeComponent();
        }

        private void TreeForm_Load(object sender, EventArgs e)
        {
            try
            {
                var parent = (MainForm)MdiParent;
                connection.ConnectionString = parent.connectionString;

                var adapter = new SqlDataAdapter();

                foreach (var table in parent.GetTablesList())
                {
                    adapter = new SqlDataAdapter("Select * From " + table, connection);
                    adapter.Fill(dataSet, table);
                }

                CreateTreeView();
                databaseTreeViev.ExpandAll();
                databaseTreeViev.SelectedNode = databaseTreeViev.Nodes[0].Nodes[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateTreeView()
        {
            for(var i = 0; i < dataSet.Tables.Count; i++)
            {
                var treeNode = new TreeNode(dataSet.Tables[i].TableName);
                databaseTreeViev.Nodes.Add(treeNode);
                for (var j = 0; j < dataSet.Tables[i].Rows.Count; j++)
                {
                    if (i == 0)
                    {
                        var treeNode2 = new TreeNode(dataSet.Tables[dataSet.Tables[i].TableName].Rows[j][2].ToString())
                        {
                            Tag = dataSet.Tables[dataSet.Tables[i].TableName].Rows[j][2].ToString()
                        };
                        treeNode.Nodes.Add(treeNode2);
                    }
                    else
                    {
                        var treeNode2 = new TreeNode(dataSet.Tables[dataSet.Tables[i].TableName].Rows[j][1].ToString())
                        {
                            Tag = dataSet.Tables[dataSet.Tables[i].TableName].Rows[j][1].ToString()
                        };
                        treeNode.Nodes.Add(treeNode2);
                    }
                }
            }
        }

        private void databaseTreeViev_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                treeViewList.Items.Clear();

                TreeNode selectedNode = databaseTreeViev.SelectedNode;
                treeViewList.Items.Add(selectedNode.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
