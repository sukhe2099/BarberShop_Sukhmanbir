using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BarberShop_Sukhmanbir.Buss
{
    public class Booking
    {
        public int ID { get; set; }
        public int StaffID { get; set; }
        public int CustomerID { get; set; }

        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }
        public Staff Staff { get; set; }
        public Customer Customer { get; set; }
    }
}
