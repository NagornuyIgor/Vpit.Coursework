using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Vpit.Coursework
{
    public partial class RowForm : Form
    {
        private const int rowHeight = 26;

        public DataTable Table { get; set; }
        public DataRow Row { get; set; }

        protected bool isEditing;

        private RowForm()
        {
            InitializeComponent();           
        }

        public RowForm(DataRow row) : this()
        {
            Row = row;
            Table = Row.Table;

            isEditing = true;
        }

        public RowForm(DataTable table) : this()
        {
            Table = table;
            Row = Table.NewRow();

            isEditing = false;
        }

        private void RowForm_Load(object sender, EventArgs e)
        {
            var x = 12;
            var y = 15;
            foreach (var column in Table.Columns.Cast<DataColumn>().Select(c => c.ColumnName))
            {
                if (column == "Id")
                {
                    continue;
                }

                Height += rowHeight;

                Controls.Add(new Label
                {
                    AutoSize = true,
                    Location = new Point(x, y),
                    Name = "label" + column,
                    Size = new Size(35, 13),
                    Text = column
                });

                Controls.Add(new TextBox
                {
                    Location = new Point(x + 100, y - 3),
                    Name = "textBox" + column,
                    Size = new Size(160, 20),
                    Text = isEditing ? Row[column].ToString() : ""
                });

                y += rowHeight;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            foreach (DataColumn column in Table.Columns)
            {
                if (column.ColumnName == "Id")
                {
                    continue;
                }

                var textBox = (TextBox)Controls["textBox" + column.ColumnName];
                Row[column] = textBox.Text;
            }
        }
    }
}
