namespace DevExWithEntity.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Country = c.String(),
                        City = c.String(),
                        District = c.String(),
                        Neighborhood = c.String(),
                        Street = c.String(),
                        PostalCode = c.String(),
                        CustomerID = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdateDate = c.DateTime(),
                        UpdatedBy = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 150),
                        Surname = c.String(maxLength: 250),
                        DateOfBirth = c.DateTime(),
                        CompanyName = c.String(maxLength: 500),
                        CustomerCode = c.String(maxLength: 50),
                        CustomerType = c.Byte(nullable: false),
                        TaxNumber = c.String(maxLength: 50),
                        Notes = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdateDate = c.DateTime(),
                        UpdatedBy = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Emails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EmailAddress = c.String(),
                        EmailType = c.Byte(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdateDate = c.DateTime(),
                        UpdatedBy = c.String(),
                        IsPrimaryEmail = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PhoneNumber = c.String(),
                        CountryCode = c.String(),
                        PhoneType = c.Byte(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdateDate = c.DateTime(),
                        UpdatedBy = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phones", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Emails", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Addresses", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Phones", new[] { "CustomerID" });
            DropIndex("dbo.Emails", new[] { "CustomerID" });
            DropIndex("dbo.Addresses", new[] { "CustomerID" });
            DropTable("dbo.Phones");
            DropTable("dbo.Emails");
            DropTable("dbo.Customers");
            DropTable("dbo.Addresses");
        }
    }
}
