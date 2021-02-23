using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace orderFollowing
{
    class cSqlGeneralCommands
    {
        public SqlConnection connectionString = new SqlConnection("Data Source=R-BILGISAYAR; Initial Catalog=cafe; Integrated Security=SSPI");
        public SqlCommand sqlCommand;
    }
}
