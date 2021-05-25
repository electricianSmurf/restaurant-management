using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace orderFollowing//.classes
{
    class cCategoryOperations
    {
        cSqlGeneralCommands generalSqlCommands = new cSqlGeneralCommands();

        public string sqlQuery;
        public DataTable dataTable;

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
    }
}
