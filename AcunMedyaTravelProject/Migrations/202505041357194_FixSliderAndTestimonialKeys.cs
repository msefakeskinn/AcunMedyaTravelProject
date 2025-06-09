namespace AcunMedyaTravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixSliderAndTestimonialKeys : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sliders", "Title", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sliders", "Title", c => c.Int(nullable: false));
        }
    }
}
