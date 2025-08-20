namespace DevExWithEntity.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tabs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TabName = c.String(),
                        FormNo = c.String(),
                        OpenDate = c.DateTime(nullable: false),
                        FirstOpenDate = c.DateTime(nullable: false),
                        OpenCount = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tabs", "UserID", "dbo.Users");
            DropIndex("dbo.Tabs", new[] { "UserID" });
            DropTable("dbo.Tabs");
        }
    }
}
