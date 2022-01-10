using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAD301_January_2022_DataModel_S00197425
{
    [Table("Flight")]
    public class Flight
    {
        [Key]
        public int FlightID { get; set; }
        public string FlightNumber {get; set;}
        public DateTime DepartureDate { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Country { get; set; }
        public int MaxSeats { get; set; }

    }
}
