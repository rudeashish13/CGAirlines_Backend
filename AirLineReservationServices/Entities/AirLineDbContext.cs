using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AirLineReservationServices.Entities
{
    public class AirLineDbContext:DbContext
    {
        //Entity Sets
        public DbSet<User> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Flight> Flights { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-59JM72CK\SQLEXPRESS;Database=AirLineDb;Integrated Security=true");
        }
    }
}
