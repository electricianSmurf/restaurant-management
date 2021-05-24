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
    class cUpdateProduct
    {
        cSqlGeneralCommands sqlGeneralCommands = new cSqlGeneralCommands();
        public string sqlQuery;

        public string productName;
        public string content;
        public decimal price;
        public bool status;

        public void updateProductInfo()
        {
            using (sqlGeneralCommands.connectionString)
            {
                using (sqlGeneralCommands.sqlCommand = new SqlCommand())
                {
                    sqlGeneralCommands.sqlCommand.Connection = sqlGeneralCommands.connectionString;

                    sqlGeneralCommands.sqlCommand.CommandText = sqlQuery;

                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@product", productName);
                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@content", content);
                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@price", price);
                    sqlGeneralCommands.sqlCommand.Parameters.AddWithValue("@status", status);

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
