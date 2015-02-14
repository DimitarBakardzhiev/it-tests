namespace IT_Tests.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CoreDBUpdates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "Difficulty", c => c.Int(nullable: false));
            AddColumn("dbo.Categories", "IsChoosable", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "Points", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Points");
            DropColumn("dbo.Categories", "IsChoosable");
            DropColumn("dbo.Questions", "Difficulty");
        }
    }
}
