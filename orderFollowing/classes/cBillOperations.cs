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
    class cBillOperations
    {
        cSqlGeneralCommands sqlGeneralCommands = new cSqlGeneralCommands();
        private SqlDataAdapter dataAdapter;
        public DataTable dataTable;

        public string sqlQuery;
        public int tableId;
        public int billId;
        public decimal additionalCost;
        public DateTime openingTime;
        public DateTime closingTime;

        public void insertNewBill()
        {
            using (sqlGeneralCommands.connectionString)
            {
                using (sqlGeneralCommands.sqlCommand = new SqlCommand())
                {
                    sqlGeneralCommands.sqlCommand.Connection = sqlGeneralCommands.connectionString;
                    sqlGeneralCommands.sqlCommand.CommandText = sqlQuery;

                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@tableId", tableId);
                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@openingTime", openingTime);

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
        public void closeBill()
        {
            using (sqlGeneralCommands.connectionString)
            {
                using (sqlGeneralCommands.sqlCommand = new SqlCommand())
                {
                    sqlGeneralCommands.sqlCommand.Connection = sqlGeneralCommands.connectionString;
                    sqlGeneralCommands.sqlCommand.CommandText = sqlQuery;

                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@tableId", tableId);
                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@billId", billId);
                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@closingTime", closingTime);

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
        public void addPriceToTotal()
        {
            using (sqlGeneralCommands.connectionString)
            {
                using (sqlGeneralCommands.sqlCommand = new SqlCommand())
                {
                    sqlGeneralCommands.sqlCommand.Connection = sqlGeneralCommands.connectionString;
                    sqlGeneralCommands.sqlCommand.CommandText = sqlQuery;

                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@tableId", tableId);
                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@billId", billId);
                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@addCost", additionalCost);

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
        public void getBillId()
        {
            sqlGeneralCommands.connectionString.Open();
            sqlGeneralCommands.sqlCommand = new SqlCommand(sqlQuery, sqlGeneralCommands.connectionString);
            sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@tableId", tableId);
            dataTable = new DataTable();
            dataAdapter = new SqlDataAdapter(sqlGeneralCommands.sqlCommand);
            dataAdapter.Fill(dataTable);
            sqlGeneralCommands.connectionString.Close();

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
        public void getAllBills()
        {
            sqlGeneralCommands.connectionString.Open();
            sqlGeneralCommands.sqlCommand = new SqlCommand(sqlQuery, sqlGeneralCommands.connectionString);
            sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@open", openingTime);
            sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@closed", closingTime);
            dataTable = new DataTable();
            dataAdapter = new SqlDataAdapter(sqlGeneralCommands.sqlCommand);
            dataAdapter.Fill(dataTable);
            sqlGeneralCommands.connectionString.Close();

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
