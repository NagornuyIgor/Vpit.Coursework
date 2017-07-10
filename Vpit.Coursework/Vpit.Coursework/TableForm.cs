using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace Vpit.Coursework
{
    public partial class TableForm : Form
    {
        public string TableName { get; set; }
        protected SqlDataAdapter dataAdapter;
        protected string connectionString;
        public Dictionary<string, string> functions;

        public TableForm(string tableName)
        {
            InitializeComponent();
            TableName = tableName;

            functions = new Dictionary<string, string>
            {
                { "Number of lines", "count" },
                { "Maximum value", "max" },
                { "Minimum value", "min" },
                { "Amount", "sum" },
                { "Average value", "avg" }
            };
        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            var parent = (MainForm)MdiParent;
            connectionString = parent.connectionString;

            dataAdapter = new SqlDataAdapter($"SELECT * FROM [{TableName}]", connectionString);

            var table = new DataTable();
            dataAdapter.Fill(table);

            tableBindingSource.DataSource = table;
            tableBindingNavigator.BindingSource = tableBindingSource;
            tableDataGridView.DataSource = tableBindingSource;

            foreach (DataColumn column in table.Columns)
            {
                columnsComboBox.Items.Add(column.ColumnName);
            }

            foreach (var function in functions.Keys)
            {
                functionsComboBox.Items.Add(function);
            }           
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string id;
            string query;
            var rowsCount = tableDataGridView.SelectedRows.Count;

            if(rowsCount != 0)
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    for (var i = 0; i < rowsCount; i++)
                    {
                        id = tableDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                        query = $"DELETE FROM {TableName} Where Id=" + id;

                        using (var command = new SqlCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }

                        tableDataGridView.Rows.Remove(tableDataGridView.SelectedRows[0]);
                    }
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали строки!");
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var table = (DataTable)tableBindingSource.DataSource;

            var rowForm = new RowForm(table);
            if (rowForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            table.Rows.Add(rowForm.Row);

            var builder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(table);

            table = new DataTable();
            dataAdapter.Fill(table);
            tableBindingSource.DataSource = table;
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            var table = (DataTable)tableBindingSource.DataSource;

            var rowView = (DataRowView)tableBindingSource.Current;
            var rowForm = new RowForm(rowView.Row);
            if (rowForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var builder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(table);

            table = new DataTable();
            dataAdapter.Fill(table);
            tableBindingSource.DataSource = table;
        }

        private void btnRunFunction_Click(object sender, EventArgs e)
        {
            try
            {
                var query = "SELECT " + functions[functionsComboBox.SelectedItem.ToString()] + "(" + columnsComboBox.SelectedItem.ToString() + ") FROM " + TableName;
                using (var connection = new SqlConnection(connectionString))
                {
                    var command = new SqlCommand(query, connection);
                    connection.Open();
                    var value = command.ExecuteScalar();
                    functionResultTextBox.Text = value.ToString();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sortAscendingButton_Click(object sender, EventArgs e)
        {
            try
            { 
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var dataView = new DataView((DataTable)tableBindingSource.DataSource)
                    {
                        Sort = columnsComboBox.SelectedItem.ToString() + " ASC"
                    };
                    tableDataGridView.DataSource = dataView;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void sortDescendingButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var dataView = new DataView((DataTable)tableBindingSource.DataSource)
                    {
                        Sort = columnsComboBox.SelectedItem.ToString() + " DESC"
                    };
                    tableDataGridView.DataSource = dataView;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void functionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            functionResultTextBox.Clear();
        }

        private void saveInExelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var app = new Excel.Application()
            {
                Visible = true
            };

            Excel.Workbook book = app.Workbooks.Add();

            Excel.Worksheet sheet = book.Worksheets[1];
            sheet.Range["A1"].Value = TableName;

            var table = (DataTable)tableBindingSource.DataSource;

            for (var i = 0; i < table.Columns.Count; i++)
            {
                sheet.Cells[2, i + 1] = table.Columns[i].ColumnName;
            }

            for (var i = 0; i < table.Rows.Count; i++)
            {
                for (var j = 0; j < table.Columns.Count; j++)
                {
                    sheet.Cells[i + 3, j + 1] = table.Rows[i][j].ToString();
                }
            }
        }

        private void saveInWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                object missingValue = Missing.Value;
                var app = new Word.Application()
                {
                    Visible = true
                };
                Word.Document doc = app.Documents.Add(ref missingValue, ref missingValue, ref missingValue, ref missingValue);
                doc.Activate();

                doc.ActiveWindow.Selection.TypeText("Table");
                doc.ActiveWindow.Selection.Font.Color = Word.WdColor.wdColorBlack;
                doc.ActiveWindow.Selection.Font.Size = 20;
                doc.ActiveWindow.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                doc.ActiveWindow.Selection.TypeParagraph();

                doc.ActiveWindow.Selection.TypeText(TableName);
                doc.ActiveWindow.Selection.Font.Color = Word.WdColor.wdColorBlack;
                doc.ActiveWindow.Selection.TypeParagraph();

                var dataTable = (DataTable)tableBindingSource.DataSource;

                doc.ActiveWindow.Selection.Font.Color = Word.WdColor.wdColorBlack;
                doc.ActiveWindow.Selection.Font.Size = 12;
                Word.Table table = doc.Tables.Add(doc.Application.Selection.Range, dataTable.Rows.Count + 1, dataTable.Columns.Count, ref missingValue, ref missingValue);
                doc.ActiveWindow.Selection.TypeParagraph();


                for (var i = 0; i < dataTable.Columns.Count; i++)
                {
                    table.Cell(1, i + 1).Range.Text = dataTable.Columns[i].ColumnName;
                }

                for (var i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (var j = 0; j < dataTable.Columns.Count; j++)
                    {
                        table.Cell(i + 2, j + 1).Range.Text = dataTable.Rows[i][j].ToString();
                    }
                }
                object line = Word.WdUnits.wdLine;
                object count = 25;
                doc.Application.Selection.MoveDown(ref line, ref count, ref missingValue);

                doc.ActiveWindow.Selection.TypeParagraph();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}