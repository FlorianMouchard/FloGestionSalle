namespace FloGestionSalles.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Civilities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Label = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CivilityID = c.Int(nullable: false),
                        Lastname = c.String(nullable: false, maxLength: 50),
                        Firstname = c.String(nullable: false, maxLength: 50),
                        Mail = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        Password = c.String(nullable: false),
                        ConfirmedPassword = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Civilities", t => t.CivilityID, cascadeDelete: true)
                .Index(t => t.CivilityID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "CivilityID", "dbo.Civilities");
            DropIndex("dbo.Users", new[] { "CivilityID" });
            DropTable("dbo.Users");
            DropTable("dbo.Civilities");
        }
    }
}
