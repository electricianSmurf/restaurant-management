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
    class cPaymentOperations
    {
        cSqlGeneralCommands sqlGeneralCommands = new cSqlGeneralCommands();
        public string sqlQuery;

        public int tableId;
        public int billId;
        public int total;
        public DateTime paymentTime;
        public int paymentType;

        public DateTime paymentStartTime;
        public DateTime paymentFinishTime;

        private SqlDataAdapter dataAdapter;
        public DataTable dataTable = new DataTable();

        public void viewPayments()
        {
            try
            {
                sqlGeneralCommands.connectionString.Open();
                sqlGeneralCommands.sqlCommand = new SqlCommand(sqlQuery, sqlGeneralCommands.connectionString);

                sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@startTime", paymentStartTime);
                sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@finishTime", paymentFinishTime);

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

        public void addNewPayment()
        {
            using (sqlGeneralCommands.connectionString)
            {
                using (sqlGeneralCommands.sqlCommand = new SqlCommand())
                {
                    sqlGeneralCommands.sqlCommand.Connection = sqlGeneralCommands.connectionString;

                    sqlGeneralCommands.sqlCommand.CommandText = sqlQuery;

                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@tableId", tableId);
                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@billId", billId);

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

        public void closePayment()
        {
            using (sqlGeneralCommands.connectionString)
            {
                using (sqlGeneralCommands.sqlCommand = new SqlCommand())
                {
                    sqlGeneralCommands.sqlCommand.Connection = sqlGeneralCommands.connectionString;

                    sqlGeneralCommands.sqlCommand.CommandText = sqlQuery;

                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@tableId", tableId);
                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@billId", billId);
                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@total", total);
                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@payTime", paymentTime);
                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@pType", paymentType);

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
