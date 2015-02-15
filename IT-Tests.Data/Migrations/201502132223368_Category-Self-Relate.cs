namespace IT_Tests.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategorySelfRelate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "ParentCategoryId", c => c.Int());
            CreateIndex("dbo.Categories", "ParentCategoryId");
            AddForeignKey("dbo.Categories", "ParentCategoryId", "dbo.Categories", "Id");
            DropColumn("dbo.Categories", "ParentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "ParentId", c => c.Int());
            DropForeignKey("dbo.Categories", "ParentCategoryId", "dbo.Categories");
            DropIndex("dbo.Categories", new[] { "ParentCategoryId" });
            DropColumn("dbo.Categories", "ParentCategoryId");
        }
    }
}
