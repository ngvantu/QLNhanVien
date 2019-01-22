namespace AutoCheckTicketSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AutoTickSystem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        CardID = c.Int(nullable: false, identity: true),
                        CusID = c.Int(nullable: false),
                        TypeID = c.Int(nullable: false),
                        IsUsed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CardID)
                .ForeignKey("dbo.Customers", t => t.CusID, cascadeDelete: true)
                .ForeignKey("dbo.TypeTickets", t => t.TypeID, cascadeDelete: true)
                .Index(t => t.CusID)
                .Index(t => t.TypeID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CusID = c.Int(nullable: false, identity: true),
                        FullName = c.String(unicode: false),
                        Birthday = c.DateTime(nullable: false, precision: 0),
                        Email = c.String(unicode: false),
                        PhoneNumber = c.Int(nullable: false),
                        Identity = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.CusID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        FullName = c.String(unicode: false),
                        Birthday = c.DateTime(nullable: false, precision: 0),
                        Identity = c.String(unicode: false),
                        ImageID = c.String(unicode: false),
                        IsUsed = c.Boolean(nullable: false),
                        Role = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        TicketID = c.Int(nullable: false, identity: true),
                        From = c.DateTime(nullable: false, precision: 0),
                        To = c.DateTime(nullable: false, precision: 0),
                        IsUsed = c.Boolean(nullable: false),
                        TypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TicketID)
                .ForeignKey("dbo.TypeTickets", t => t.TypeID, cascadeDelete: true)
                .Index(t => t.TypeID);
            
            CreateTable(
                "dbo.TypeTickets",
                c => new
                    {
                        TypeID = c.Int(nullable: false, identity: true),
                        TypeName = c.String(unicode: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TypeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "TypeID", "dbo.TypeTickets");
            DropForeignKey("dbo.Cards", "TypeID", "dbo.TypeTickets");
            DropForeignKey("dbo.Cards", "CusID", "dbo.Customers");
            DropIndex("dbo.Tickets", new[] { "TypeID" });
            DropIndex("dbo.Cards", new[] { "TypeID" });
            DropIndex("dbo.Cards", new[] { "CusID" });
            DropTable("dbo.TypeTickets");
            DropTable("dbo.Tickets");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
            DropTable("dbo.Cards");
        }
    }
}
