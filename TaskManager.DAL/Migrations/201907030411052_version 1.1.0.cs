namespace TaskManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version110 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tasks", "CreatedOn", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tasks", "CreatedOn", c => c.DateTime(nullable: false));
        }
    }
}
