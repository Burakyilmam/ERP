namespace DevExWithEntity.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(),
                        MachineName = c.String(),
                        DeviceInfo = c.String(),
                        WindowsUsername = c.String(),
                        IPAddress = c.String(),
                        LoginDate = c.DateTime(nullable: false),
                        SessionDuration = c.Time(precision: 7),
                        LogoutDate = c.DateTime(),
                        LastActivityDate = c.DateTime(),
                        ActiveForm = c.String(),
                        FailedLoginAttempts = c.Int(nullable: false),
                        GeoLocation = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SessionID = c.Int(nullable: false),
                        TableName = c.String(),
                        FormNo = c.String(),
                        RecordID = c.Int(nullable: false),
                        ActionType = c.Int(nullable: false),
                        ActionDate = c.DateTime(nullable: false),
                        Details = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Sessions", t => t.SessionID, cascadeDelete: true)
                .Index(t => t.SessionID);
            
            AddColumn("dbo.Users", "IsAdmin", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sessions", "UserID", "dbo.Users");
            DropForeignKey("dbo.Logs", "SessionID", "dbo.Sessions");
            DropIndex("dbo.Logs", new[] { "SessionID" });
            DropIndex("dbo.Sessions", new[] { "UserID" });
            DropColumn("dbo.Users", "IsAdmin");
            DropTable("dbo.Logs");
            DropTable("dbo.Sessions");
        }
    }
}
