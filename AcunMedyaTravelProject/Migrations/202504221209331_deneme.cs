namespace AcunMedyaTravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        DestinationsID = c.Int(nullable: false, identity: true),
                        ImageURL = c.String(),
                        Title = c.String(),
                        Description1 = c.String(),
                        Description2 = c.String(),
                    })
                .PrimaryKey(t => t.DestinationsID);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServicesID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ImageURL = c.String(),
                    })
                .PrimaryKey(t => t.ServicesID);
            
            CreateTable(
                "dbo.Sliders",
                c => new
                    {
                        SliderID = c.Int(nullable: false, identity: true),
                        Title = c.Int(nullable: false),
                        Description1 = c.String(),
                        Description2 = c.String(),
                        ImageURL = c.String(),
                    })
                .PrimaryKey(t => t.SliderID);
            
            CreateTable(
                "dbo.TripExamples",
                c => new
                    {
                        TripExampleID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description1 = c.String(),
                        IconURL = c.String(),
                        ImageURL = c.String(),
                        Description2 = c.String(),
                    })
                .PrimaryKey(t => t.TripExampleID);
            
            CreateTable(
                "dbo.Trips",
                c => new
                    {
                        TripID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description1 = c.String(),
                        Description2 = c.String(),
                        IconURL = c.String(),
                    })
                .PrimaryKey(t => t.TripID);
            
            AddColumn("dbo.Testimonials", "Title", c => c.String());
            AddColumn("dbo.Testimonials", "TestimonialName", c => c.String());
            AddColumn("dbo.Testimonials", "Degree", c => c.String());
            DropColumn("dbo.Testimonials", "Name");
            DropColumn("dbo.Testimonials", "Surname");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Testimonials", "Surname", c => c.String());
            AddColumn("dbo.Testimonials", "Name", c => c.String());
            DropColumn("dbo.Testimonials", "Degree");
            DropColumn("dbo.Testimonials", "TestimonialName");
            DropColumn("dbo.Testimonials", "Title");
            DropTable("dbo.Trips");
            DropTable("dbo.TripExamples");
            DropTable("dbo.Sliders");
            DropTable("dbo.Services");
            DropTable("dbo.Destinations");
        }
    }
}
