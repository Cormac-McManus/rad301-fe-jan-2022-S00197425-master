using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAD301_January_2022_DataModel_S00197425
{
    [Table("Passenger")]
    public class Passenger
    {
        [Key]
        public int PassengerID { get; set; }
        public string Name { get; set; }
        public string TicketType { get; set; }
        public double TicketCost { get; set; }
        public double BaggageCharge { get; set; }
        public int FlightID { get; set; }
        [ForeignKey("FlightID")]
        public virtual Flight Flight { get; set; }

    }
}
