namespace AcunMedyaTravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sponsor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sponsors",
                c => new
                    {
                        SponsorID = c.Int(nullable: false, identity: true),
                        ImageURL = c.String(),
                    })
                .PrimaryKey(t => t.SponsorID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sponsors");
        }
    }
}
