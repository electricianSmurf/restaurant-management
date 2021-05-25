using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace orderFollowing
{
    class cCategoryOperations
    {
        cSqlGeneralCommands generalSqlCommands = new cSqlGeneralCommands();

        public string sqlQuery;
        public DataTable dataTable;

        public string categoryName;

        private SqlDataAdapter dataAdapter;

        public void getCategoryNames()
        {
            try
            {
                generalSqlCommands.connectionString.Open();
                generalSqlCommands.sqlCommand = new SqlCommand(sqlQuery, generalSqlCommands.connectionString);
                dataTable = new DataTable();
                dataAdapter = new SqlDataAdapter(generalSqlCommands.sqlCommand);
                dataAdapter.Fill(dataTable);
                generalSqlCommands.connectionString.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Failed!");
            }
        }

        public void addNewCategory()
        {
            using (generalSqlCommands.connectionString)
            {
                using (generalSqlCommands.sqlCommand = new SqlCommand())
                {
                    generalSqlCommands.sqlCommand.Connection = generalSqlCommands.connectionString;
                    generalSqlCommands.sqlCommand.CommandText = sqlQuery;

                    generalSqlCommands.sqlCommand.Parameters.AddWithValue("@cName", categoryName);

                    try
                    {
                        generalSqlCommands.connectionString.Open();
                        generalSqlCommands.sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Category added!");
                        generalSqlCommands.connectionString.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Connection Failed!");
                    }

                }
            }
        }
    }
}
