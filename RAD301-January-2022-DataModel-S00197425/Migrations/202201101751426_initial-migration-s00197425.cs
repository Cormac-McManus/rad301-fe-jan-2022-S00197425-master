namespace RAD301_January_2022_DataModel_S00197425.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmigrations00197425 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Flight",
                c => new
                    {
                        FlightID = c.Int(nullable: false, identity: true),
                        FlightNumber = c.String(),
                        DepartureDate = c.DateTime(nullable: false),
                        Origin = c.String(),
                        Destination = c.String(),
                        Country = c.String(),
                        MaxSeats = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FlightID);
            
            CreateTable(
                "dbo.Passenger",
                c => new
                    {
                        PassengerID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TicketType = c.String(),
                        TicketCost = c.Double(nullable: false),
                        BaggageCharge = c.Double(nullable: false),
                        FlightID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PassengerID)
                .ForeignKey("dbo.Flight", t => t.FlightID, cascadeDelete: true)
                .Index(t => t.FlightID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Passenger", "FlightID", "dbo.Flight");
            DropIndex("dbo.Passenger", new[] { "FlightID" });
            DropTable("dbo.Passenger");
            DropTable("dbo.Flight");
        }
    }
}
