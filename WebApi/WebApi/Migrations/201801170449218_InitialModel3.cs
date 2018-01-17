namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BackgroundImage", "CreatedProgID", c => c.String());
            AddColumn("dbo.BackgroundImage", "CreatedDate", c => c.String());
            AddColumn("dbo.BackgroundImage", "CreatedUserName", c => c.String());
            AddColumn("dbo.BackgroundImage", "LastUpdate", c => c.String());
            AddColumn("dbo.BackgroundImage", "LastUserName", c => c.String());
            AddColumn("dbo.BackgroundImage", "IPAddress", c => c.String());
            AddColumn("dbo.BackgroundImage", "MACAddress", c => c.String());
            AddColumn("dbo.Information", "CreatedProgID", c => c.String());
            AddColumn("dbo.Information", "CreatedDate", c => c.String());
            AddColumn("dbo.Information", "CreatedUserName", c => c.String());
            AddColumn("dbo.Information", "LastUpdate", c => c.String());
            AddColumn("dbo.Information", "LastUserName", c => c.String());
            AddColumn("dbo.Information", "IPAddress", c => c.String());
            AddColumn("dbo.Information", "MACAddress", c => c.String());
            AddColumn("dbo.Video", "CreatedProgID", c => c.String());
            AddColumn("dbo.Video", "CreatedDate", c => c.String());
            AddColumn("dbo.Video", "CreatedUserName", c => c.String());
            AddColumn("dbo.Video", "LastUpdate", c => c.String());
            AddColumn("dbo.Video", "LastUserName", c => c.String());
            AddColumn("dbo.Video", "IPAddress", c => c.String());
            AddColumn("dbo.Video", "MACAddress", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Video", "MACAddress");
            DropColumn("dbo.Video", "IPAddress");
            DropColumn("dbo.Video", "LastUserName");
            DropColumn("dbo.Video", "LastUpdate");
            DropColumn("dbo.Video", "CreatedUserName");
            DropColumn("dbo.Video", "CreatedDate");
            DropColumn("dbo.Video", "CreatedProgID");
            DropColumn("dbo.Information", "MACAddress");
            DropColumn("dbo.Information", "IPAddress");
            DropColumn("dbo.Information", "LastUserName");
            DropColumn("dbo.Information", "LastUpdate");
            DropColumn("dbo.Information", "CreatedUserName");
            DropColumn("dbo.Information", "CreatedDate");
            DropColumn("dbo.Information", "CreatedProgID");
            DropColumn("dbo.BackgroundImage", "MACAddress");
            DropColumn("dbo.BackgroundImage", "IPAddress");
            DropColumn("dbo.BackgroundImage", "LastUserName");
            DropColumn("dbo.BackgroundImage", "LastUpdate");
            DropColumn("dbo.BackgroundImage", "CreatedUserName");
            DropColumn("dbo.BackgroundImage", "CreatedDate");
            DropColumn("dbo.BackgroundImage", "CreatedProgID");
        }
    }
}
