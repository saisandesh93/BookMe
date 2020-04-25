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
    class CustomerDAO
    {
        private static SqlConnection con = DbcTrial.getconnection();

        public CustomerDAO()
        {
        }

        public void insertCustomer(Customer myCustomer)
        {

            String query = "INSERT INTO Customer (Name,Age,Gender) VALUES (@Name,@Age,@Gender)";
            con.Open();

            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@Name", myCustomer.Name);
            command.Parameters.AddWithValue("@Age", myCustomer.Age);
            command.Parameters.AddWithValue("@Gender", myCustomer.Gender);

            command.ExecuteNonQuery();
        }
    }
}
