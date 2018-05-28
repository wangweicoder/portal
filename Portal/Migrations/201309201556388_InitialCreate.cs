namespace Portal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Province",
                c => new
                    {
                        ProvinceID = c.Int(nullable: false, identity: true),
                        ProvinceNo = c.String(maxLength: 10),
                        ProvinceName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ProvinceID);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.CategoryID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Category");
            DropTable("dbo.Province");
        }
    }
}
