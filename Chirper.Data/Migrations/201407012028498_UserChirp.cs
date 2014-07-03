namespace Chirper.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserChirp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chirps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        Time = c.DateTime(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserChirps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ChirpId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Chirps", t => t.ChirpId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ChirpId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        UserName = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserChirps", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserChirps", "ChirpId", "dbo.Chirps");
            DropIndex("dbo.UserChirps", new[] { "ChirpId" });
            DropIndex("dbo.UserChirps", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.UserChirps");
            DropTable("dbo.Chirps");
        }
    }
}
