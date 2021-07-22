using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ticket_BookingAPI.Models;

namespace Ticket_BookingAPI.Data
{
    public class Ticket_BookingAPIContext : DbContext
    {
        public Ticket_BookingAPIContext (DbContextOptions<Ticket_BookingAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Ticket_BookingAPI.Models.Booking> Booking { get; set; }
    }
}
