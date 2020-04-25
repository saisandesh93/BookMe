using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Models
{
    class BookAppointment
    {
        public long BookingId { get; set; }
        public long customerId { get; set; }
        //public long CustomerId { get { return customerId; } }
        public long serviceProviderId { get; set; }
        public DateTime Date { get; set; }

    }
}
