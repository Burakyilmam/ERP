namespace DevExWithEntity.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        Title = c.String(),
                        Content = c.String(),
                        IsRead = c.Boolean(nullable: false),
                        RelatedForm = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        NotificationType = c.Byte(nullable: false),
                        Priority = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notifications", "UserID", "dbo.Users");
            DropIndex("dbo.Notifications", new[] { "UserID" });
            DropTable("dbo.Notifications");
        }
    }
}
