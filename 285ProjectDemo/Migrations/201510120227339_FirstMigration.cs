namespace _285ProjectDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "FirstName", c => c.String());
            AddColumn("dbo.Users", "LastName", c => c.String());
            AddColumn("dbo.Users", "Email", c => c.String());
            DropColumn("dbo.Users", "Name");
            DropColumn("dbo.Users", "classification");
            DropColumn("dbo.Users", "orientation");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "orientation", c => c.String());
            AddColumn("dbo.Users", "classification", c => c.String());
            AddColumn("dbo.Users", "Name", c => c.String());
            DropColumn("dbo.Users", "Email");
            DropColumn("dbo.Users", "LastName");
            DropColumn("dbo.Users", "FirstName");
        }
    }
}
