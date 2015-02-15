namespace IT_Tests.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CoreDBUpdates : DbMigration
    {
        public override void Up()
        {
            this.AddColumn("dbo.Questions", "Difficulty", c => c.Int(nullable: false));
            this.AddColumn("dbo.Categories", "IsChoosable", c => c.Boolean(nullable: false));
            this.AddColumn("dbo.AspNetUsers", "Points", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            this.DropColumn("dbo.AspNetUsers", "Points");
            this.DropColumn("dbo.Categories", "IsChoosable");
            this.DropColumn("dbo.Questions", "Difficulty");
        }
    }
}
