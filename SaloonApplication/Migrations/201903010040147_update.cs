namespace SaloonApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "dateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Services", "dateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Services", "dateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Customers", "dateTime");
        }
    }
}
