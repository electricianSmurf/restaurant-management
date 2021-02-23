using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;

namespace orderFollowing
{
    class cStaffActivities
    {
        cSqlGeneralCommands sqlGeneralCommands = new cSqlGeneralCommands();
        public string sqlQuery;

        public string name;
        public string duty;
        public string userName;
        public string password;
        public string photo;
        public DateTime entranceTime;
        public DateTime exitTime;
        public void insertStaffActivity()
        {
            using (sqlGeneralCommands.connectionString)
            {
                using (sqlGeneralCommands.sqlCommand = new SqlCommand())
                {
                    sqlGeneralCommands.sqlCommand.Connection = sqlGeneralCommands.connectionString;

                    sqlGeneralCommands.sqlCommand.CommandText = sqlQuery;
                    //sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@name", name);
                    //sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@duty", duty);
                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@userName", userName);
                    //sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@password", password);
                    //sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@photo", photo);
                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@entrance", entranceTime);
                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@exit", exitTime);
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
        public void updateStaffActivity()
        {
            using (sqlGeneralCommands.connectionString)
            {
                using (sqlGeneralCommands.sqlCommand = new SqlCommand())
                {
                    sqlGeneralCommands.sqlCommand.Connection = sqlGeneralCommands.connectionString;

                    sqlGeneralCommands.sqlCommand.CommandText = sqlQuery;
                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@userName", userName);
                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@exit", exitTime);
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

        /*select staffNameSurname, dutyName, staffUserName, staffPhoto, entranceTime, exitTime from STAFFS, STAFFACTIVITY, DUTIES
where STAFFS.staffID = STAFFACTIVITY.staffID and STAFFS.staffDuty = DUTIES.dutyID*/
    }
}
