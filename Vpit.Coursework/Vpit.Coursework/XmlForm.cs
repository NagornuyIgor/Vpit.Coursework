using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Vpit.Coursework
{
    public partial class XmlForm : Form
    {
        public XmlForm()
        {
            InitializeComponent();
        }
        DataSet dataSet = new DataSet();

        private void createFirstTableButton_Click(object sender, EventArgs e)
        {
            var table = new DataTable("PoliceStations");
            DataColumn col;

            col = new DataColumn("Id")
            {
                DataType = Type.GetType("System.Int32"),
                AutoIncrement = true,
                AutoIncrementStep = 1,
                AutoIncrementSeed = 1
            };
            table.Columns.Add(col);

            col = new DataColumn("Address", Type.GetType("System.String"))
            {
                MaxLength = 255
            };
            table.Columns.Add(col);

            DataColumn[] prkey = new DataColumn[1];
            prkey[0] = table.Columns["Id"];
            table.PrimaryKey = prkey;

            if (!dataSet.Tables.Contains("PoliceStations"))
            {
                dataSet.Tables.Add(table);
            }

            firstDvgTable.DataSource = dataSet.Tables["PoliceStations"];
        }

        private void fillFirstTableButton_Click(object sender, EventArgs e)
        {
            if (dataSet.Tables["PoliceStations"] != null)
            {
                DataRow row = dataSet.Tables["PoliceStations"].NewRow();
                row["Address"] = "Kooperatyvna 9";
                dataSet.Tables["PoliceStations"].Rows.Add(row);

                row = dataSet.Tables["PoliceStations"].NewRow();
                row["Address"] = "Tobolska 67";
                dataSet.Tables["PoliceStations"].Rows.Add(row);

                row = dataSet.Tables["PoliceStations"].NewRow();
                row["Address"] = "Literaturna 124a";
                dataSet.Tables["PoliceStations"].Rows.Add(row);

                row = dataSet.Tables["PoliceStations"].NewRow();
                row["Address"] = "prospekt Nauky 331";
                dataSet.Tables["PoliceStations"].Rows.Add(row);

                row = dataSet.Tables["PoliceStations"].NewRow();
                row["Address"] = "Riazanska 13";
                dataSet.Tables["PoliceStations"].Rows.Add(row);

            }
            else
            {
                MessageBox.Show("No Table");
            }
        }

        private void createSecondTableButton_Click(object sender, EventArgs e)
        {
            var table = new DataTable("Policemen");
            DataColumn col;

            col = new DataColumn("Id")
            {
                DataType = Type.GetType("System.Int32"),
                AutoIncrement = true,
                AutoIncrementStep = 1,
                AutoIncrementSeed = 1
            };
            table.Columns.Add(col);

            col = new DataColumn("Name", Type.GetType("System.String"))
            {
                MaxLength = 255
            };
            table.Columns.Add(col);

            col = new DataColumn("Surname", Type.GetType("System.String"))
            {
                MaxLength = 255
            };
            table.Columns.Add(col);

            col = new DataColumn("Rank", Type.GetType("System.String"))
            {
                MaxLength = 255
            };
            table.Columns.Add(col);

            col = new DataColumn("WorkExperience", Type.GetType("System.DateTime"));
            table.Columns.Add(col);

            col = new DataColumn("PoliceStationId", Type.GetType("System.Int32"));
            table.Columns.Add(col);

            col = new DataColumn("Birthday", Type.GetType("System.DateTime"));
            table.Columns.Add(col);

            DataColumn[] prkey = new DataColumn[1];
            prkey[0] = table.Columns["Id"];
            table.PrimaryKey = prkey;

            if (!dataSet.Tables.Contains("Policemen"))
            {
                dataSet.Tables.Add(table);
            }

            secondDvgTable.DataSource = dataSet.Tables["Policemen"];
        }

        private void fillSecondTableButton_Click(object sender, EventArgs e)
        {
            if (dataSet.Tables["Policemen"] != null)
            {
                DataRow row = dataSet.Tables["Policemen"].NewRow();
                object[] obj = new object[dataSet.Tables["Policemen"].Columns.Count];
                obj[1] = "Ivan";
                obj[2] = "Petrov";
                obj[3] = "General";
                obj[4] = "03.04.1993";
                obj[5] = 1;
                obj[6] = "04.11.1961";
                row.ItemArray = obj;
                dataSet.Tables["Policemen"].Rows.Add(row);

                row = dataSet.Tables["Policemen"].NewRow();
                obj = new object[dataSet.Tables["Policemen"].Columns.Count];
                obj[1] = "Valeriy";
                obj[2] = "Milytin";
                obj[3] = "Colonel";
                obj[4] = "05.06.2000";
                obj[5] = 2;
                obj[6] = "03.12.1971";
                row.ItemArray = obj;
                dataSet.Tables["Policemen"].Rows.Add(row);

                row = dataSet.Tables["Policemen"].NewRow();
                obj = new object[dataSet.Tables["Policemen"].Columns.Count];
                obj[1] = "Vasiliy";
                obj[2] = "Nogin";
                obj[3] = "General";
                obj[4] = "06.06.1994 ";
                obj[5] = 3;
                obj[6] = "06.07.1966";
                row.ItemArray = obj;
                dataSet.Tables["Policemen"].Rows.Add(row);

                row = dataSet.Tables["Policemen"].NewRow();
                obj = new object[dataSet.Tables["Policemen"].Columns.Count];
                obj[1] = "Nikolay";
                obj[2] = "Migunov";
                obj[3] = "General";
                obj[4] = "07.11.2003";
                obj[5] = 4;
                obj[6] = "04.04.1988";
                row.ItemArray = obj;
                dataSet.Tables["Policemen"].Rows.Add(row);

                row = dataSet.Tables["Policemen"].NewRow();
                obj = new object[dataSet.Tables["Policemen"].Columns.Count];
                obj[1] = "Vladimir";
                obj[2] = "Panin";
                obj[3] = "Colonel";
                obj[4] = "09.11.2001";
                obj[5] = 5;
                obj[6] = "06.03.1979";
                row.ItemArray = obj;
                dataSet.Tables["Policemen"].Rows.Add(row);
            }
            else
            {
                MessageBox.Show("No Table");
            }
        }

        private void createRelationshipButton_Click(object sender, EventArgs e)
        {
            if (dataSet.Tables["Policemen"] != null && dataSet.Tables["PoliceStations"] != null)
            {
                var relation = new DataRelation("PoliceStations_Policemen",
                dataSet.Tables["PoliceStations"].Columns["Id"],
                dataSet.Tables["Policemen"].Columns["PoliceStationId"]);
                if (!dataSet.Relations.Contains("PoliceStations_Policemen"))
                {
                    dataSet.Relations.Add(relation);
                }
            }
            else
            {
                MessageBox.Show("No Table");
            }
        }

        private void saveXmlButton_Click(object sender, EventArgs e)
        {
            var fileStream = new FileStream("XmlSchema.xml", FileMode.Create);
            dataSet.WriteXmlSchema(fileStream);
            fileStream.Close();

            fileStream = new FileStream("XmlDoc.xml", FileMode.Create);
            dataSet.WriteXml(fileStream);
            fileStream.Close();
        }

        private void readXmlButton_Click(object sender, EventArgs e)
        {
            tablesComboBox.Items.Clear();

            try
            {
                dataSet = new DataSet();
                var fileStream = new FileStream("XmlSchema.xml", FileMode.Open);
                dataSet.ReadXmlSchema(fileStream);
                fileStream.Close();

                fileStream = new FileStream("XmlDoc.xml", FileMode.Open);
                dataSet.ReadXml(fileStream);
                fileStream.Close();

                firstXmlTable.DataSource = dataSet.Tables["PoliceStations"];
                secondXmlTable.DataSource = dataSet.Tables["Policemen"];

                ShowSchemaBD();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowSchemaBD()
        {
            foreach (DataTable table in dataSet.Tables)
            {
                tablesComboBox.Items.Add(table.TableName);
            }

            tablesComboBox.SelectedIndex = 0;
        }

        private void tablesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            columnsListBox.Items.Clear();

            foreach (DataColumn column in dataSet.Tables[tablesComboBox.SelectedItem.ToString()].Columns)
            {
                columnsListBox.Items.Add(column.ColumnName);
            }
        }
    }
}
