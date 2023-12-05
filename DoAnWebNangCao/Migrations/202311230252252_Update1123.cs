namespace DoAnWebNangCao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update1123 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_ProductImage",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Image = c.String(),
                        IsDefault = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tb_Product", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            AddColumn("dbo.tb_OrderDetail", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.tb_Product", "ViewCount", c => c.Int(nullable: false));
            AlterColumn("dbo.tb_Product", "PriceSale", c => c.Decimal(precision: 18, scale: 2));
            DropColumn("dbo.tb_OrderDetail", "Quatity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_OrderDetail", "Quatity", c => c.Int(nullable: false));
            DropForeignKey("dbo.tb_ProductImage", "ProductId", "dbo.tb_Product");
            DropIndex("dbo.tb_ProductImage", new[] { "ProductId" });
            AlterColumn("dbo.tb_Product", "PriceSale", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.tb_Product", "ViewCount");
            DropColumn("dbo.tb_OrderDetail", "Quantity");
            DropTable("dbo.tb_ProductImage");
        }
    }
}
