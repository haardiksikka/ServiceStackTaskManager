namespace TaskManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version200 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tasks", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Tasks", "UserStory", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.Users", "FirstName", c => c.String());
            AlterColumn("dbo.Tasks", "UserStory", c => c.String());
            AlterColumn("dbo.Tasks", "Email", c => c.String());
        }
    }
}
