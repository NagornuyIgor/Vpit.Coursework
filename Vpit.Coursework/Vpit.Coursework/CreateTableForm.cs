using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Vpit.Coursework
{
    public partial class CreateTableForm : Form
    {
        DataTable dataTable;
        Dictionary<string, Type> dataTypes;
        DBComands dataBaseCommands;

        public CreateTableForm()
        {
            InitializeComponent();

            dataTable = new DataTable();
            dataBaseCommands = new DBComands();

            dataTypes = new Dictionary<string, Type>()
            {
                { "string", typeof(string) },
                { "int", typeof(int) },
                { "boolean", typeof(bool) },
                { "char", typeof(char) },
                { "byte", typeof(byte) },
                { "date time", typeof(DateTime) }
            };

            SetPrimaryKey();
        }

        public void CreateTable()
        {
            var parent = (MainForm)MdiParent;

            if ((string.IsNullOrEmpty(tableNameTextBox.Text)))
            {
                MessageBox.Show("TextBox in empty");
            }
            else
            {
                dataTable.TableName = tableNameTextBox.Text;
                AddColumns();

                dataBaseCommands.CreateTableCommand(dataTable);
                parent.AddTableToToolStrips(dataTable.TableName);


                MessageBox.Show("Table Created");
            }
        }

        private void addRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createTableDataGridView.Rows.Add();     
        }

        private void deleteColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rowsCount = createTableDataGridView.SelectedRows.Count;

            for (var i = 0; i < rowsCount; i++)
            {
                createTableDataGridView.Rows.Remove(createTableDataGridView.SelectedRows[0]);
            }
        }

        private void saveTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Validate();
            CreateTable();
        }

        private void SetPrimaryKey()
        {
            var column = new DataColumn("Id", typeof(int))
            {
                AutoIncrement = true,
                AutoIncrementSeed = 0,
                AutoIncrementStep = 1
            };
            dataTable.Columns.Add(column);

            dataTable.PrimaryKey = new[] { column };
        }

        public void AddColumns()
        {
            for (var i = 0; i < createTableDataGridView.RowCount; i++)
            {
                DataGridViewCellCollection inputColumn = createTableDataGridView.Rows[i].Cells;

                dataTable.Columns.Add(inputColumn[0].Value.ToString(), dataTypes[inputColumn[1].Value.ToString()]);
            }
        }
    }
}
