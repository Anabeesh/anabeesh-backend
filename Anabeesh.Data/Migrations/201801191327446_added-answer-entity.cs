namespace Anabeesh.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedanswerentity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Body = c.String(nullable: false),
                        UserId = c.String(nullable: false, maxLength: 128),
                        QuestionsId = c.Long(nullable: false),
                        IsDeleted = c.Boolean(),
                        CreationTime = c.DateTime(),
                        DeletionTime = c.DateTime(),
                        ModificationTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Questions", t => t.QuestionsId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.QuestionsId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Answers", "QuestionsId", "dbo.Questions");
            DropForeignKey("dbo.Answers", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Answers", new[] { "QuestionsId" });
            DropIndex("dbo.Answers", new[] { "UserId" });
            DropTable("dbo.Answers");
        }
    }
}
