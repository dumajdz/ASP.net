namespace DoAnWebNangCao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateActive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Category", "IsAtive", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_News", "IsAtive", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_Posts", "IsAtive", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_Product", "IsAtive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Product", "IsAtive");
            DropColumn("dbo.tb_Posts", "IsAtive");
            DropColumn("dbo.tb_News", "IsAtive");
            DropColumn("dbo.tb_Category", "IsAtive");
        }
    }
}
