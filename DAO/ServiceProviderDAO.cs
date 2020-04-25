using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.DataSource;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2.DAO
{
    class ServiceProviderDAO
    {
        SqlConnection con;
        ServiceProviderDAO()
        {
            con = DbcTrial.getconnection();
        }

        public void insertServiceProvider(ServiceProvider myServiceProvider)
        {

            String query = "INSERT INTO ServiceProvider (Name,Location,Category,Price) VALUES (@Name,@Location,@Category,@Price)";
            con.Open();

            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@Name", myServiceProvider.Name);
            command.Parameters.AddWithValue("@Location", myServiceProvider.Location);
            command.Parameters.AddWithValue("@Category", myServiceProvider.Category);
            command.Parameters.AddWithValue("@Price", myServiceProvider.Price);


            command.ExecuteNonQuery();
        }
    }
}
