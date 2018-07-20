namespace FloGestionSalles.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRoomFile : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RoomFiles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ContentType = c.String(nullable: false, maxLength: 100),
                        Name = c.String(nullable: false, maxLength: 254),
                        Content = c.Binary(nullable: false),
                        RoomID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Rooms", t => t.RoomID, cascadeDelete: true)
                .Index(t => t.RoomID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoomFiles", "RoomID", "dbo.Rooms");
            DropIndex("dbo.RoomFiles", new[] { "RoomID" });
            DropTable("dbo.RoomFiles");
        }
    }
}
