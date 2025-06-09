namespace AcunMedyaTravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_diagram : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Destinations", "CategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Destinations", "CategoryID");
            AddForeignKey("dbo.Destinations", "CategoryID", "dbo.Categories", "CategoryID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Destinations", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Destinations", new[] { "CategoryID" });
            DropColumn("dbo.Destinations", "CategoryID");
        }
    }
}
