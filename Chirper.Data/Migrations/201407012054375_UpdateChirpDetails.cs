namespace Chirper.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateChirpDetails : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Chirps", "UserName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Chirps", "UserName", c => c.String());
        }
    }
}
