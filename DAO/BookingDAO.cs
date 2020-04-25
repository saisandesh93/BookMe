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
    class BookingDAO
    {
        SqlConnection con;
        BookingDAO() 
        {
            con = DbcTrial.getconnection();
        }

        public void insertBooking(BookAppointment myBooking)
        {

            String query = "INSERT INTO BookAppointments (customerId,serviceProviderId,Date) VALUES (@customerId,@serviceProviderId,@Date)";
            con.Open();

            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@customerId", myBooking.customerId);
            command.Parameters.AddWithValue("@serviceProviderId", myBooking.serviceProviderId);
            command.Parameters.AddWithValue("@Date", myBooking.Date);

            command.ExecuteNonQuery();


        }
    }
}
