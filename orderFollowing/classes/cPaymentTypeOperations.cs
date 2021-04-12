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
    class cPaymentTypeOperations
    {
        cSqlGeneralCommands sqlGeneralCommands = new cSqlGeneralCommands();
        public string sqlQuery;

        public string paymentType;

        private SqlDataAdapter dataAdapter;
        public DataTable dataTable = new DataTable();

        public void showPaymentTypes()
        {
            try
            {
                sqlGeneralCommands.connectionString.Open();
                sqlGeneralCommands.sqlCommand = new SqlCommand(sqlQuery, sqlGeneralCommands.connectionString);
                
                dataTable = new DataTable();
                dataAdapter = new SqlDataAdapter(sqlGeneralCommands.sqlCommand);
                dataAdapter.Fill(dataTable);
                sqlGeneralCommands.connectionString.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Failed!");
            }
        }

        public bool checkIsPTypeAlive()
        {
            try
            {
                sqlGeneralCommands.connectionString.Open();
                sqlGeneralCommands.sqlCommand = new SqlCommand(sqlQuery, sqlGeneralCommands.connectionString);

                sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@PType", paymentType);

                dataTable = new DataTable();
                dataAdapter = new SqlDataAdapter(sqlGeneralCommands.sqlCommand);
                dataAdapter.Fill(dataTable);
                sqlGeneralCommands.connectionString.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Failed!");
            }

            return checkPTypeExplanation();
        }

        private bool checkPTypeExplanation()
        {
            bool isTheSame = false;

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                if (paymentType == dataTable.Rows[row]["explanation"].ToString())
                {
                    isTheSame = true;
                    break;
                }
            }
            return isTheSame;
        }

        public void addNewPType()
        {
            using (sqlGeneralCommands.connectionString)
            {
                using (sqlGeneralCommands.sqlCommand = new SqlCommand())
                {
                    sqlGeneralCommands.sqlCommand.Connection = sqlGeneralCommands.connectionString;

                    sqlGeneralCommands.sqlCommand.CommandText = sqlQuery;

                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@PType", paymentType);

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
