namespace MentalHealthTracker.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsersUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Entries", "User_UserId", "dbo.Users");
            DropIndex("dbo.Entries", new[] { "User_UserId" });
            AddColumn("dbo.Entries", "User", c => c.String());
            DropColumn("dbo.Entries", "User_UserId");
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Guid(nullable: false),
                        Email = c.String(),
                        Password = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            AddColumn("dbo.Entries", "User_UserId", c => c.Guid());
            DropColumn("dbo.Entries", "User");
            CreateIndex("dbo.Entries", "User_UserId");
            AddForeignKey("dbo.Entries", "User_UserId", "dbo.Users", "UserId");
        }
    }
}
