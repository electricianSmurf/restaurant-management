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
    class cAddNewProduct
    {
        cSqlGeneralCommands generalCommands = new cSqlGeneralCommands();
        public string sqlQuery;

        public int category;
        public string productName;
        public string content;
        public decimal price;
        public bool status;

        public void addProduct()
        {
            using (generalCommands.connectionString)
            {
                using (generalCommands.sqlCommand = new SqlCommand())
                {
                    generalCommands.sqlCommand.Connection = generalCommands.connectionString;
                    generalCommands.sqlCommand.CommandText = sqlQuery;

                    generalCommands.sqlCommand.Parameters.AddWithValue("@category", category);
                    generalCommands.sqlCommand.Parameters.AddWithValue("@product", productName);
                    generalCommands.sqlCommand.Parameters.AddWithValue("@content", content);
                    generalCommands.sqlCommand.Parameters.AddWithValue("@price", price);
                    generalCommands.sqlCommand.Parameters.AddWithValue("@status", status);

                    try
                    {
                        generalCommands.connectionString.Open();
                        generalCommands.sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Product Added!");
                        generalCommands.connectionString.Close();
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
