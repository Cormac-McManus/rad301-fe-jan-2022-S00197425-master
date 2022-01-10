namespace RAD301_January_2022_DataModel_S00197425.Migrations
{
    using CsvHelper;
    using CsvHelper.Configuration;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using Tracker.WebAPIClient;

    internal sealed class Configuration : DbMigrationsConfiguration<RAD301_January_2022_DataModel_S00197425.FlightContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RAD301_January_2022_DataModel_S00197425.FlightContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            ActivityAPIClient.Track(StudentID: "S00197425", StudentName: "Comac McManus", activityName: "Rad301 January 2022", Task: "Seeding DataModel");

            
            seedPassengers(context);

        }

        private void seedFlights(FlightContext context)
        {
            List<Flight> flights = Get<Flight>("RAD301_January_2022_DataModel_S00197425.flights.csv");
            context.Flights.AddOrUpdate(f => f.FlightID, flights.ToArray());
            context.SaveChanges();
        }

        private void seedPassengers(FlightContext context)
        {
            List<Passenger> passengers = Get<Passenger>("RAD301_January_2022_DataModel_S00197425.Passengers.csv");
            context.Passengers.AddOrUpdate(p => p.PassengerID, passengers.ToArray());
        }

        public static List<T> Get<T>(string resourceName)
        {
            // Get the current assembly
            Assembly assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {   // create a stream reader
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    CsvConfiguration configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
                    { HasHeaderRecord = false };
                    // create a csv reader dor the stream
                    CsvReader csvReader = new CsvReader(reader, configuration);
                    return csvReader.GetRecords<T>().ToList();
                }
            }
        }
    }
}
