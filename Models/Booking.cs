using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ticket_BookingAPI.Models
{
    public class Booking
    {[Key]
        public int Booking_ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
       

    }
}
