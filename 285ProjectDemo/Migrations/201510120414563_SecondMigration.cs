namespace _285ProjectDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuestionCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.QuestionModels", "CategoryID", c => c.Int(nullable: false));
            AddColumn("dbo.QuestionModels", "QuestionCategory_ID", c => c.Int());
            CreateIndex("dbo.QuestionModels", "QuestionCategory_ID");
            AddForeignKey("dbo.QuestionModels", "QuestionCategory_ID", "dbo.QuestionCategories", "ID");
            DropColumn("dbo.QuestionModels", "Importance");
        }
        
        public override void Down()
        {
            AddColumn("dbo.QuestionModels", "Importance", c => c.Int(nullable: false));
            DropForeignKey("dbo.QuestionModels", "QuestionCategory_ID", "dbo.QuestionCategories");
            DropIndex("dbo.QuestionModels", new[] { "QuestionCategory_ID" });
            DropColumn("dbo.QuestionModels", "QuestionCategory_ID");
            DropColumn("dbo.QuestionModels", "CategoryID");
            DropTable("dbo.QuestionCategories");
        }
    }
}
