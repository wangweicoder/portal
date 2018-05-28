namespace Portal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyCity1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.City", "CreateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.City", "CreateTime");
        }
    }
}
