namespace Chirper.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserFollowerModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserFollowers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        FollowerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.FollowerId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.UserId)
                .Index(t => t.FollowerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserFollowers", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserFollowers", "FollowerId", "dbo.Users");
            DropIndex("dbo.UserFollowers", new[] { "FollowerId" });
            DropIndex("dbo.UserFollowers", new[] { "UserId" });
            DropTable("dbo.UserFollowers");
        }
    }
}
