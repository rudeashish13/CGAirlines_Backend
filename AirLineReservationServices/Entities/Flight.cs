using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AirLineReservationServices.Entities
{

    [Table("Flights")]
    public class Flight
    {
        //FlightId 
        [Column(TypeName ="int")]
        public int FlightID { get; set; }

        //
        [Column(TypeName = "Date")]
        public DateTime LaunchDate { get; set; }

        //SOurce Airport
        [Required]
        [StringLength(10)]
        [Column(TypeName = "Varchar")]
        public string Origin { get; set; }


        //destination airport
        [Required]
        [StringLength(10)]
        [Column(TypeName = "Varchar")]
        public string Destination { get; set; }


        //departure time of flight from source
        
        [Column(TypeName = "Date")]
        public DateTime DeptTime { get; set; }

        //arrival time of flight at destination
        [Column(TypeName = "Date")]
        public DateTime ArrivalTime { get; set; }

        //no of seats passenger wants to book
        [Required]
        [Column(TypeName = "int")]
        public int NoOfSeats { get; set; }

        //cost of a trip
        [Column(TypeName = "decimal")]
        public float Fare { get; set; }

    }
}
