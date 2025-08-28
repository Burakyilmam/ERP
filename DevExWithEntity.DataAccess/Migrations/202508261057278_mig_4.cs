namespace DevExWithEntity.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Calenders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CurrentDate = c.DateTime(nullable: false),
                        Title = c.String(),
                        Note = c.String(),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Calenders", "UserID", "dbo.Users");
            DropIndex("dbo.Calenders", new[] { "UserID" });
            DropTable("dbo.Calenders");
        }
    }
}
