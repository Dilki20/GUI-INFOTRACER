namespace First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class qrdata : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.QRCodes", "QRData", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.QRCodes", "QRData");
        }
    }
}
