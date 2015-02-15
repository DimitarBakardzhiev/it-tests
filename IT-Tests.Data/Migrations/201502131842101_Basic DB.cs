namespace IT_Tests.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BasicDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        QuestionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.QuestionId, cascadeDelete: true)
                .Index(t => t.QuestionId);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ParentId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            this.DropForeignKey("dbo.Questions", "CategoryId", "dbo.Categories");
            this.DropForeignKey("dbo.Answers", "QuestionId", "dbo.Questions");
            this.DropIndex("dbo.Questions", new[] { "CategoryId" });
            this.DropIndex("dbo.Answers", new[] { "QuestionId" });
            this.DropTable("dbo.Categories");
            this.DropTable("dbo.Questions");
            this.DropTable("dbo.Answers");
        }
    }
}
