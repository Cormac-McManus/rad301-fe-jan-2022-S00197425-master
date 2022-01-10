using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAD301_January_2022_DataModel_S00197425
{
    public class FlightContext : DbContext
    {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }

        public FlightContext()
            : base("Rad301January2022Connection")
        { 
        }

        public static FlightContext Create()
        {
            return new FlightContext();
        }
    }
}
