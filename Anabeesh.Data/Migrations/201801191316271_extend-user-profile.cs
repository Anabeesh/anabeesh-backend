namespace Anabeesh.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class extenduserprofile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.AspNetUsers", "MiddleName", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.AspNetUsers", "Country", c => c.Byte(nullable: false));
            AddColumn("dbo.AspNetUsers", "Phone", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Gender", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "NumberOfFollowers", c => c.Long(nullable: false));
            AddColumn("dbo.AspNetUsers", "NumberOfFollowing", c => c.Long(nullable: false));
            AddColumn("dbo.AspNetUsers", "NumberOfQuestions", c => c.Long(nullable: false));
            AddColumn("dbo.AspNetUsers", "NumberOfAnswers", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "NumberOfAnswers");
            DropColumn("dbo.AspNetUsers", "NumberOfQuestions");
            DropColumn("dbo.AspNetUsers", "NumberOfFollowing");
            DropColumn("dbo.AspNetUsers", "NumberOfFollowers");
            DropColumn("dbo.AspNetUsers", "Gender");
            DropColumn("dbo.AspNetUsers", "Phone");
            DropColumn("dbo.AspNetUsers", "Country");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "MiddleName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
