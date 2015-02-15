namespace IT_Tests.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstName : DbMigration
    {
        public override void Up()
        {
            this.AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            this.AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
        }   
        
        public override void Down()
        {
            this.DropColumn("dbo.AspNetUsers", "LastName");
            this.DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}