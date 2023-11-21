namespace DoAnWebNangCao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameIsAtiveToIsActive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Adv", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Category", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_Category", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_News", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_News", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Posts", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_Posts", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Contact", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Order", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Product", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_ProductCategory", "ModifiedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.tb_Adv", "ModifiedrDate");
            DropColumn("dbo.tb_Category", "IsAtive");
            DropColumn("dbo.tb_Category", "ModifiedrDate");
            DropColumn("dbo.tb_News", "IsAtive");
            DropColumn("dbo.tb_News", "ModifiedrDate");
            DropColumn("dbo.tb_Posts", "IsAtive");
            DropColumn("dbo.tb_Posts", "ModifiedrDate");
            DropColumn("dbo.tb_Contact", "ModifiedrDate");
            DropColumn("dbo.tb_Order", "ModifiedrDate");
            DropColumn("dbo.tb_Product", "ModifiedrDate");
            DropColumn("dbo.tb_ProductCategory", "ModifiedrDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_ProductCategory", "ModifiedrDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Product", "ModifiedrDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Order", "ModifiedrDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Contact", "ModifiedrDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Posts", "ModifiedrDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Posts", "IsAtive", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_News", "ModifiedrDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_News", "IsAtive", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_Category", "ModifiedrDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Category", "IsAtive", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_Adv", "ModifiedrDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.tb_ProductCategory", "ModifiedDate");
            DropColumn("dbo.tb_Product", "ModifiedDate");
            DropColumn("dbo.tb_Order", "ModifiedDate");
            DropColumn("dbo.tb_Contact", "ModifiedDate");
            DropColumn("dbo.tb_Posts", "ModifiedDate");
            DropColumn("dbo.tb_Posts", "IsActive");
            DropColumn("dbo.tb_News", "ModifiedDate");
            DropColumn("dbo.tb_News", "IsActive");
            DropColumn("dbo.tb_Category", "ModifiedDate");
            DropColumn("dbo.tb_Category", "IsActive");
            DropColumn("dbo.tb_Adv", "ModifiedDate");
        }
    }
}
