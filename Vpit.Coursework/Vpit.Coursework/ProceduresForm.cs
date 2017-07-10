using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Vpit.Coursework
{
    public partial class ProceduresForm : Form
    {
        DataSet dataSet = new DataSet();
        SqlCommand command;
        string tableName, columnname;
        string connectionString;
        int index = 0;

        public ProceduresForm()
        {
            InitializeComponent();
        }

        void FillDataTable()
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    tableNameComboBox.Items.Clear();
                    paramTableNameComboBox.Items.Clear();
                    connection.Open();
                    DataTable schema = connection.GetSchema("Tables");
                    foreach (DataRow row in schema.Rows)
                    {
                        tableNameComboBox.Items.Add((string)row[2]);
                        paramTableNameComboBox.Items.Add((string)row[2]);
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }

        private void ProceduresForm_Load(object sender, EventArgs e)
        {
            var parent = (MainForm)MdiParent;
            connectionString = parent.connectionString;
            FillDataTable();
        }

        private void createProcedureButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    tableName = tableNameComboBox.SelectedItem.ToString();
                    var cmdText = "CREATE PROCEDURE GetTable" + tableName + " AS SELECT* FROM " + tableName;
                    command = new SqlCommand(cmdText, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Procedure created.");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void executeProcedureButton_Click(object sender, EventArgs e)
        {
            dataSet.Clear();

            var connection = new SqlConnection(connectionString);
            try
            {                  
                    var stProc = new SqlCommand("GetTable" + tableName, connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    var ad = new SqlDataAdapter(stProc);
                    connection.Open();
                    ad.Fill(dataSet, tableName);
                    procedureDataGridView.DataSource = dataSet.Tables[tableName];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void deleteProcedureButton_Click(object sender, EventArgs e)
        {
            var query = "DROP PROCEDURE GetTable" + tableName;
            
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    command = new SqlCommand(query, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Procedure deleted.");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                procedureDataGridView.Columns.Clear();
                tableName = null;
            }
        }

        private void createParameterProcedureButton_Click(object sender, EventArgs e)
        {
            try
            {
                tableName = paramTableNameComboBox.SelectedItem.ToString();
                columnname = columnNameComboBox.SelectedItem.ToString();
                var query = "CREATE PROCEDURE Procedure" + index + " @param VarChar(255) As SELECT * FROM " + tableName + " WHERE " + columnname + " = @param;";

                using (var connection = new SqlConnection(connectionString))
                {
                    command = new SqlCommand(query, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                MessageBox.Show("Stored procedure with the parameter is created.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void executeParameterProcedureButton_Click(object sender, EventArgs e)
        {
            dataSet.Clear();

            if (dataSet.Tables["Procedure" + index] != null)
            {
                dataSet.Tables["Procedure" + index].Clear();
            }

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var stoledProcedure = new SqlCommand("Procedure" + index, connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    var dataAdapter = new SqlDataAdapter(stoledProcedure);
                    var param = new SqlParameter()
                    {
                        ParameterName = "@param",
                        Value = ParameterTextBox.Text
                    };
                    stoledProcedure.Parameters.Add(param);
                    connection.Open();
                    dataAdapter.Fill(dataSet, "Procedure" + index);
                    procedureDataGridView.DataSource = dataSet.Tables["Procedure" + index];
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteParameterProcedureButton_Click(object sender, EventArgs e)
        {
            var query = "DROP PROCEDURE Procedure" + index;
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    command = new SqlCommand(query, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Stored procedure with the parameter is deleted.");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                procedureDataGridView.Columns.Clear();
                tableName = null;
                index++;
            }
        }

        private void paramTableNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                columnNameComboBox.Items.Clear();

                var dataAdapter = new SqlDataAdapter($"SELECT * FROM [{paramTableNameComboBox.SelectedItem.ToString()}]", connectionString);
                dataAdapter.Fill(dataSet, paramTableNameComboBox.SelectedItem.ToString());

                foreach (DataColumn column in dataSet.Tables[paramTableNameComboBox.SelectedItem.ToString()].Columns)
                {
                    columnNameComboBox.Items.Add(column.ColumnName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void columnNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            parameterLabel.Text = "( " + columnNameComboBox.SelectedItem.ToString() + " ):";
        }
    }
}
