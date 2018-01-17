namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Content", "CreatedProgID", c => c.String());
            AddColumn("dbo.Content", "CreatedDate", c => c.String());
            AddColumn("dbo.Content", "CreatedUserName", c => c.String());
            AddColumn("dbo.Content", "LastUpdate", c => c.String());
            AddColumn("dbo.Content", "LastUserName", c => c.String());
            AddColumn("dbo.Content", "IPAddress", c => c.String());
            AddColumn("dbo.Content", "MACAddress", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Content", "MACAddress");
            DropColumn("dbo.Content", "IPAddress");
            DropColumn("dbo.Content", "LastUserName");
            DropColumn("dbo.Content", "LastUpdate");
            DropColumn("dbo.Content", "CreatedUserName");
            DropColumn("dbo.Content", "CreatedDate");
            DropColumn("dbo.Content", "CreatedProgID");
        }
    }
}
