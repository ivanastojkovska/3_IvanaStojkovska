namespace _3_IvanaStojkovska.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usermodelchangedroleadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        ConfirmPassword = c.String(nullable: false),
                        DateRegistered = c.DateTime(nullable: false),
                        Roles = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Links",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LinkUrl = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.User_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Links", "User_ID", "dbo.Users");
            DropIndex("dbo.Links", new[] { "User_ID" });
            DropTable("dbo.Links");
            DropTable("dbo.Users");
        }
    }
}
