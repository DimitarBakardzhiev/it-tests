namespace IT_Tests.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategorySelfRelate : DbMigration
    {
        public override void Up()
        {
            this.AddColumn("dbo.Categories", "ParentCategoryId", c => c.Int());
            this.CreateIndex("dbo.Categories", "ParentCategoryId");
            this.AddForeignKey("dbo.Categories", "ParentCategoryId", "dbo.Categories", "Id");
            this.DropColumn("dbo.Categories", "ParentId");
        }
        
        public override void Down()
        {
            this.AddColumn("dbo.Categories", "ParentId", c => c.Int());
            this.DropForeignKey("dbo.Categories", "ParentCategoryId", "dbo.Categories");
            this.DropIndex("dbo.Categories", new[] { "ParentCategoryId" });
            this.DropColumn("dbo.Categories", "ParentCategoryId");
        }  
    }       
}
