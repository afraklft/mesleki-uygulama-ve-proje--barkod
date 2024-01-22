using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace barkod.Classes
{
    public class sqlConnectionClass
    {
     public static SqlConnection connect = new SqlConnection("Data Source=DESKTOP-FMJ3SBS\\MSSQLSERVER01;Initial Catalog=market;Integrated Security=True;");

        public static void CheckConnection(SqlConnection tempConnection)
        {
            if (tempConnection.State==System.Data.ConnectionState.Closed)
            {
                tempConnection.Open();
            }
            else
            {

            }
        }
    }
}
