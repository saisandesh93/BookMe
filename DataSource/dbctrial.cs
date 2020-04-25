using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;



namespace WindowsFormsApp2.DataSource
{
    class DbcTrial
    {
      public static SqlConnection getconnection() 
        {

            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                return con;
            }
        }
    }
}
