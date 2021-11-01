namespace First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userLogin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserLogins",
                c => new
                    {
                        UserLoginID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserLoginID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserLogins");
        }
    }
}
