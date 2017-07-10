using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Vpit.Coursework
{
    public partial class RelationForm : Form
    {
        SqlConnection connection = new SqlConnection();
        DataSet dataSet = new DataSet();
        int relationIndex = 0;
        string connectionString;

        ICollection<string> tables;

        public RelationForm()
        {
            InitializeComponent();
        }

        private void RelationForm_Load(object sender, EventArgs e)
        {
            var parent = (MainForm)MdiParent;
            connection.ConnectionString = parent.connectionString;
            tables = parent.GetTablesList();
            foreach(var table in tables)
            {
                firstTableComboBox.Items.Add(table);
                secondTableComboBox.Items.Add(table);
            }
            connectionString = parent.connectionString;
        }

        private void firstTableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                firstTableColumnsListBox.Items.Clear();

                var dataAdapter = new SqlDataAdapter($"SELECT * FROM [{firstTableComboBox.SelectedItem.ToString()}]", connectionString);
                dataAdapter.Fill(dataSet, firstTableComboBox.SelectedItem.ToString());

                foreach (DataColumn column in dataSet.Tables[firstTableComboBox.SelectedItem.ToString()].Columns)
                {
                    firstTableColumnsListBox.Items.Add(column.ColumnName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void secondTableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                secondTableColumnsListBox.Items.Clear();

                var dataAdapter = new SqlDataAdapter($"SELECT * FROM [{secondTableComboBox.SelectedItem.ToString()}]", connectionString);
                dataAdapter.Fill(dataSet, secondTableComboBox.SelectedItem.ToString());

                foreach (DataColumn column in dataSet.Tables[secondTableComboBox.SelectedItem.ToString()].Columns)
                {
                    secondTableColumnsListBox.Items.Add(column.ColumnName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createRelationButton_Click(object sender, EventArgs e)
        {
            var query = "Alter Table " + firstTableComboBox.SelectedItem.ToString() + " add constraint rel" + relationIndex + " foreign key(" + firstTableColumnsListBox.SelectedItem.ToString() + ") references " + secondTableComboBox.SelectedItem.ToString() + "(" + secondTableColumnsListBox.SelectedItem.ToString() + ")";
            var command = new SqlCommand(query);
            try
            {
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Relation created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void deleteRelationButton_Click(object sender, EventArgs e)
        {
            var query = "Alter Table " + firstTableComboBox.SelectedItem.ToString() + " drop constraint rel" + relationIndex + " ;";
            var command = new SqlCommand(query);
            relationIndex++;
            try
            {
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Relation deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
