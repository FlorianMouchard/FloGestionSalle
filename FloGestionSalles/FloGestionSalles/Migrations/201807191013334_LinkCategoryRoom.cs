namespace FloGestionSalles.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LinkCategoryRoom : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "CategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Rooms", "CategoryID");
            AddForeignKey("dbo.Rooms", "CategoryID", "dbo.Categories", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Rooms", new[] { "CategoryID" });
            DropColumn("dbo.Rooms", "CategoryID");
        }
    }
}
