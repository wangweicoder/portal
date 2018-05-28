namespace Portal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyCity : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.City", "ProvinceNo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.City", "ProvinceNo", c => c.String(maxLength: 10));
        }
    }
}
