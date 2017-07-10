using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Vpit.Coursework
{
    public partial class QueryForm : Form
    {
        SqlConnection con = new SqlConnection();
        DataSet dataSet = new DataSet();
        private BindingSource bindingSource = new BindingSource();
        string[] querys;
        public string connectionString;

        public QueryForm()
        {
            InitializeComponent();
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            var parent = (MainForm)MdiParent;
            connectionString = parent.connectionString;

            queryComboBox.Items.Add("Offender car");
            queryComboBox.Items.Add("The ticket to the offender has written out");
            queryComboBox.Items.Add("Offenses");
            queryComboBox.Items.Add("PoliceStations Chief");

            querys = new string[] {
                "Select Offenders.[Name], Offenders.[Surname], Cars.[Model], Cars.[LicencePlate], Cars.[Color] from Offenders inner join Cars on Offenders.[CarId] = Cars.[Id];",
                "Select Policemen.[Name], Policemen.[Surname], Offenders.[Name], Offenders.[Surname], Tickets.[Protocol] from ((Tickets inner join Offenders on Tickets.[OffenderId] = Offenders.[Id]) inner join Policemen on Tickets.[PolicemanId] = Policemen.[Id]);",
                "Select OffenseTypes.[Name], Punishments.[Type], Punishments.[Term] from OffenseTypes inner join Punishments on OffenseTypes.[PunishmentId] = Punishments.[Id];",
                "Select PoliceStations.[Address], Policemen.[Name], Policemen.[Surname], Policemen.[Rank] from PoliceStations inner join Policemen on PoliceStations.[ChiefId] = Policemen.[Id];"
            };
        }

        private void queryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            queryDataGridView.Columns.Clear();
        }

        private void executeQueryButton_Click(object sender, EventArgs e)
        {
            switch (queryComboBox.SelectedIndex.ToString())
            {
                case "0":
                {
                    try
                    {
                        executeQuery(querys[0]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                }

                case "1":
                {
                    try
                    {
                        using (var connection = new SqlConnection(connectionString))
                        {
                            var command = new SqlCommand(querys[1], connection);
                            var table = new DataTable();
                            connection.Open();
                            table.Load(command.ExecuteReader());
                            table.Columns[2].ColumnName = "Offender name";
                            table.Columns[3].ColumnName = "Offender Surname";
                            bindingSource.DataSource = table.DefaultView;
                            queryDataGridView.DataSource = bindingSource;
                            connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                }

                case "2":
                {
                    try
                    {
                        executeQuery(querys[2]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                }

                case "3":
                {
                    try
                    {
                        executeQuery(querys[3]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                }

                default:
                    MessageBox.Show("Select query!");
                    break;
            }
        }

        public void executeQuery(string query)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                var table = new DataTable();
                connection.Open();
                table.Load(command.ExecuteReader());
                bindingSource.DataSource = table.DefaultView;
                queryDataGridView.DataSource = bindingSource;
                connection.Close();
            }
        }
    }
}
