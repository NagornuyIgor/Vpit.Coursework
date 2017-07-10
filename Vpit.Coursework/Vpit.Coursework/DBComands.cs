using System;
using System.Collections.Generic;
using System.Configuration;
using System.Configuration.Provider;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vpit.Coursework
{
    public class DBComands
    {
        public string connectionString;
        public DBComands()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Vpit.Coursework.Properties.Settings.PoliceDbConnectionString"].ConnectionString;
        }
        public DBComands(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Dictionary<string, string> dataTypes = new Dictionary<string, string>
        {
            { "System.String", "varchar(max)" },
            { "System.Int32", "int" },
            { "System.Boolean", "bit" },
            { "System.DateTime", "datetime" }
        };

        public void CreateTableCommand(DataTable table)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var createTableText = new StringBuilder();
                try
                {
                    createTableText.Append("CREATE TABLE ");
                    createTableText.Append(EscapeName(table.TableName));
                    createTableText.Append(" (");

                    foreach (DataColumn column in table.Columns)
                    {
                        createTableText.Append(EscapeName(column.ColumnName));
                        createTableText.Append(" ");
                        createTableText.Append(dataTypes[column.DataType.ToString()]);

                        if (column.ColumnName == "Id")
                        {
                            createTableText.Append(" IDENTITY(1,1) PRIMARY KEY, ");
                        }
                        else
                        {
                            createTableText.Append(column.AllowDBNull ? " NOT NULL, " : " NULL, ");
                        }
                    }
                    createTableText.Remove(createTableText.Length - 2, 2);
                    createTableText.Append(")");
                    using (var command = new SqlCommand(createTableText.ToString(), connection))
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        command.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    throw new ProviderException(ex.Message);
                }
            }
        }

        public string EscapeName(string name)
        {
            if (name.StartsWith("[", StringComparison.Ordinal) && name.EndsWith("]", StringComparison.Ordinal))
            {
                return name;
            }

            var escapedName = new StringBuilder();
            escapedName.Append('[');

            for (var i = 0; i < name.Length; i++)
            {
                var c = name[i];

                if (c == ']')
                {
                    escapedName.Append(']');
                }
                escapedName.Append(c);
            }
            escapedName.Append(']');

            return escapedName.ToString();
        }

        public void DeleteTableComand(string tableName)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("DROP TABLE " + tableName + ";", connection))
                {
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
                connection.Close();
            }
        }
    }
}
