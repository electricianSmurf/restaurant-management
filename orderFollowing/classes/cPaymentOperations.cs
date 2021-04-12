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

    }
}
