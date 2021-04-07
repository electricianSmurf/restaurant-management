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
    class cOrderOperations
    {
        cSqlGeneralCommands generalSqlCommands = new cSqlGeneralCommands();
        public string sqlQuery;

        public DateTime billStartTime;
        public DateTime billFinishTime;
        
        private SqlDataAdapter dataAdapter;
        public DataTable dataTable = new DataTable();

        public void getDataFromOrders()
        {
            try
            {
                generalSqlCommands.connectionString.Open();
                generalSqlCommands.sqlCommand = new SqlCommand(sqlQuery, generalSqlCommands.connectionString);

                generalSqlCommands.sqlCommand.Parameters.AddWithValue("@startTime", billStartTime);
                generalSqlCommands.sqlCommand.Parameters.AddWithValue("@finishTime", billFinishTime);
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
        public void showNewOrders()
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
