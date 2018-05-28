namespace Portal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.City",
                c => new
                    {
                        CityID = c.Int(nullable: false, identity: true),
                        ProvinceNo = c.String(maxLength: 10),
                        CityNo = c.String(maxLength: 10),
                        CityName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.CityID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.City");
        }
    }
}
