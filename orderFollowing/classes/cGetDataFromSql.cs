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
    class cGetDataFromSql
    {
        cSqlGeneralCommands generalSqlCommands = new cSqlGeneralCommands();
        private SqlDataAdapter dataAdapter;
        public string sqlQuery;

        public DataTable dataTable = new DataTable();

        public void GetDataFromSql()
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
