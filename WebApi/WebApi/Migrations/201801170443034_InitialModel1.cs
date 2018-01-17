namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Information",
                c => new
                    {
                        InformationID = c.String(nullable: false, maxLength: 128),
                        Descr = c.String(),
                        ContentID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.InformationID)
                .ForeignKey("dbo.Content", t => t.ContentID)
                .Index(t => t.ContentID);
            
            CreateTable(
                "dbo.Video",
                c => new
                    {
                        VideoID = c.String(nullable: false, maxLength: 128),
                        Width = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                        FileSize = c.Double(nullable: false),
                        FileType = c.String(),
                        FileName = c.String(),
                        Path = c.String(),
                        ContentID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.VideoID)
                .ForeignKey("dbo.Content", t => t.ContentID)
                .Index(t => t.ContentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Video", "ContentID", "dbo.Content");
            DropForeignKey("dbo.Information", "ContentID", "dbo.Content");
            DropIndex("dbo.Video", new[] { "ContentID" });
            DropIndex("dbo.Information", new[] { "ContentID" });
            DropTable("dbo.Video");
            DropTable("dbo.Information");
        }
    }
}
