using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace orderFollowing
{
    class cTableOperations
    {
        cSqlGeneralCommands sqlGeneralCommands = new cSqlGeneralCommands();
        public string sqlQuery;
        public string capacity;
        public bool tableStatus;
        public bool serviceStatus;
        public string tableId;

        public void addNewTable()
        {
            using (sqlGeneralCommands.connectionString)
            {
                using (sqlGeneralCommands.sqlCommand = new SqlCommand())
                {
                    sqlGeneralCommands.sqlCommand.Connection = sqlGeneralCommands.connectionString;
                    sqlGeneralCommands.sqlCommand.CommandText = sqlQuery;

                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@capacity", capacity);
                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@tableStatus", tableStatus);
                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@serviceStatus", serviceStatus);

                    try
                    {
                        sqlGeneralCommands.connectionString.Open();
                        sqlGeneralCommands.sqlCommand.ExecuteNonQuery();
                        sqlGeneralCommands.connectionString.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Connection Failed!");
                    }
                }   
            }
        }
        public void deleteTable()
        {
            using (sqlGeneralCommands.connectionString)
            {
                using (sqlGeneralCommands.sqlCommand = new SqlCommand())
                {
                    sqlGeneralCommands.sqlCommand.Connection = sqlGeneralCommands.connectionString;
                    sqlGeneralCommands.sqlCommand.CommandText = "update TABLES set tableStatus = 0 where tableID = @tableId";

                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@tableId", tableId);

                    try
                    {
                        sqlGeneralCommands.connectionString.Open();
                        sqlGeneralCommands.sqlCommand.ExecuteNonQuery();
                        sqlGeneralCommands.connectionString.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Connection Failed!");
                    }
                }
            }
        }
        public void openNewAccount()
        {
            using (sqlGeneralCommands.connectionString)
            {
                using (sqlGeneralCommands.sqlCommand = new SqlCommand())
                {
                    sqlGeneralCommands.sqlCommand.Connection = sqlGeneralCommands.connectionString;
                    sqlGeneralCommands.sqlCommand.CommandText = "update tables set serviceStatus = 1 where tableID = @tableId"; ;

                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@tableId", tableId);

                    try
                    {
                        sqlGeneralCommands.connectionString.Open();
                        sqlGeneralCommands.sqlCommand.ExecuteNonQuery();
                        sqlGeneralCommands.connectionString.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Connection Failed!");
                    }
                }
            }
        }
        public void closeAccount()
        {
            using (sqlGeneralCommands.connectionString)
            {
                using (sqlGeneralCommands.sqlCommand = new SqlCommand())
                {
                    sqlGeneralCommands.sqlCommand.Connection = sqlGeneralCommands.connectionString;
                    sqlGeneralCommands.sqlCommand.CommandText = "update TABLES set serviceStatus = 0 where tableID = @tableId";

                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@tableId", tableId);

                    try
                    {
                        sqlGeneralCommands.connectionString.Open();
                        sqlGeneralCommands.sqlCommand.ExecuteNonQuery();
                        sqlGeneralCommands.connectionString.Close();
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
