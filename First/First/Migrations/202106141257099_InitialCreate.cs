namespace First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        No = c.String(),
                        Street = c.String(),
                        City1 = c.String(),
                        City2 = c.String(),
                    })
                .PrimaryKey(t => t.AddressId);
            
            CreateTable(
                "dbo.QRCodes",
                c => new
                    {
                        QRCodeID = c.Int(nullable: false, identity: true),
                        ImageToByte = c.Binary(),
                    })
                .PrimaryKey(t => t.QRCodeID);
            
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        ShopID = c.Int(nullable: false, identity: true),
                        ShopName = c.String(),
                        ShopCategory = c.String(),
                        Email = c.String(),
                        ContactNo = c.Int(nullable: false),
                        Address_AddressId = c.Int(),
                    })
                .PrimaryKey(t => t.ShopID)
                .ForeignKey("dbo.Addresses", t => t.Address_AddressId)
                .Index(t => t.Address_AddressId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        NIC_NO = c.String(),
                        MobileNo = c.Int(nullable: false),
                        Address_AddressId = c.Int(),
                        QRCode_QRCodeID = c.Int(),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Addresses", t => t.Address_AddressId)
                .ForeignKey("dbo.QRCodes", t => t.QRCode_QRCodeID)
                .Index(t => t.Address_AddressId)
                .Index(t => t.QRCode_QRCodeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "QRCode_QRCodeID", "dbo.QRCodes");
            DropForeignKey("dbo.Users", "Address_AddressId", "dbo.Addresses");
            DropForeignKey("dbo.Shops", "Address_AddressId", "dbo.Addresses");
            DropIndex("dbo.Users", new[] { "QRCode_QRCodeID" });
            DropIndex("dbo.Users", new[] { "Address_AddressId" });
            DropIndex("dbo.Shops", new[] { "Address_AddressId" });
            DropTable("dbo.Users");
            DropTable("dbo.Shops");
            DropTable("dbo.QRCodes");
            DropTable("dbo.Addresses");
        }
    }
}
