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
    class cGetTotalBill
    {
        cSqlGeneralCommands generalSqlCommands = new cSqlGeneralCommands();
        private SqlDataAdapter dataAdapter;
        public DataTable dataTable;

        public int billId;

        public string sqlQuery;

        public void getTotalBill()
        {
            using (generalSqlCommands.connectionString)
            {
                using (generalSqlCommands.sqlCommand = new SqlCommand())
                {
                    try
                    {
                        generalSqlCommands.sqlCommand.Connection = generalSqlCommands.connectionString;
                        generalSqlCommands.sqlCommand.CommandText = sqlQuery;
                        generalSqlCommands.sqlCommand.Parameters.AddWithValue("@billId", billId);
                        dataTable = new DataTable();
                        dataAdapter = new SqlDataAdapter(generalSqlCommands.sqlCommand);
                        dataAdapter.Fill(dataTable);
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
