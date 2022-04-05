using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CGAirlines.Models
{
    public class Reservations
    {
        public int TicketNo { get; set; }
        public string FlightID { get; set; }
        public DateTime DateofBooking { get; set; }
        public DateTime Journeydate { get; set; }
        public string PassengerName { get; set; }
        public int ContactNo{ get; set; }
        public string Email { get; set; }
        public int NoofTickets { get; set; }
        public double TotalFare { get; set; }
        public string Status { get; set; }
    }
}
