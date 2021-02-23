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
    class cGetOrdersFromSql
    {
        cSqlGeneralCommands generalSqlCommands = new cSqlGeneralCommands();
        public string sqlQuery;
        public string tableId;
        public int billId;
        private SqlDataAdapter dataAdapter;
        public DataTable dataTable = new DataTable();
        public void GetOrdersFromSql()
        {
            try
            {
                generalSqlCommands.connectionString.Open();
                generalSqlCommands.sqlCommand = new SqlCommand(sqlQuery, generalSqlCommands.connectionString);
                generalSqlCommands.sqlCommand.Parameters.AddWithValue("@tableId", tableId);
                generalSqlCommands.sqlCommand.Parameters.AddWithValue("@billId", billId);
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
