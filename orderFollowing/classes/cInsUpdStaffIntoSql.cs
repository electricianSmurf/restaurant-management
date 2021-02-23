using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;

namespace orderFollowing
{
    class cInsUpdStaffIntoSql
    {
        cSqlGeneralCommands sqlGeneralCommands = new cSqlGeneralCommands();
        public string sqlQuery;
        public string staffName;
        public int staffDuty;
        public string userName;
        public string password;
        public string phoneNumber;
        public bool isWorking;
        public string staffPhotoName;
        public void insertStaff()
        {
            using (sqlGeneralCommands.connectionString)
            {
                using (sqlGeneralCommands.sqlCommand = new SqlCommand())
                {
                    sqlGeneralCommands.sqlCommand.Connection = sqlGeneralCommands.connectionString;

                    sqlGeneralCommands.sqlCommand.CommandText = sqlQuery;

                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@name", staffName);
                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@duty", staffDuty);
                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@userName", userName);
                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@password", password);
                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@phone", phoneNumber);
                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@status", isWorking);
                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@photo", staffPhotoName);

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
