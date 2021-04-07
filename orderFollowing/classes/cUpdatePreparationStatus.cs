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
    class cUpdatePreparationStatus
    {
        cSqlGeneralCommands sqlGeneralCommands = new cSqlGeneralCommands();

        public string sqlQuery;

        public int billID;
        public int orderID;

        public void updatePreparationStatus()
        {
            try
            {
                using (sqlGeneralCommands.connectionString)
                {
                    using (sqlGeneralCommands.sqlCommand = new SqlCommand())
                    {
                        sqlGeneralCommands.sqlCommand.Connection = sqlGeneralCommands.connectionString;

                        sqlGeneralCommands.sqlCommand.CommandText = sqlQuery;

                        sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@billID", billID);
                        sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@orderID", orderID);

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
            catch (Exception)
            {
                MessageBox.Show("Connection Failed!");
            }
        }
    }
}
