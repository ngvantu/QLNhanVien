namespace AutoCheckTicketSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AutoTicketSystem : DbMigration
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
                "dbo.Transactions",
                c => new
                    {
                        TransID = c.Int(nullable: false, identity: true),
                        From = c.DateTime(nullable: false, precision: 0),
                        To = c.DateTime(nullable: false, precision: 0),
                        IsUsed = c.Boolean(nullable: false),
                        TypeID = c.Int(nullable: false),
                        Employee_EmployeeID = c.Int(),
                    })
                .PrimaryKey(t => t.TransID)
                .ForeignKey("dbo.Employees", t => t.Employee_EmployeeID)
                .ForeignKey("dbo.TypeTickets", t => t.TypeID, cascadeDelete: true)
                .Index(t => t.TypeID)
                .Index(t => t.Employee_EmployeeID);
            
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
            DropForeignKey("dbo.Transactions", "TypeID", "dbo.TypeTickets");
            DropForeignKey("dbo.Cards", "TypeID", "dbo.TypeTickets");
            DropForeignKey("dbo.Transactions", "Employee_EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Cards", "CusID", "dbo.Customers");
            DropIndex("dbo.Transactions", new[] { "Employee_EmployeeID" });
            DropIndex("dbo.Transactions", new[] { "TypeID" });
            DropIndex("dbo.Cards", new[] { "TypeID" });
            DropIndex("dbo.Cards", new[] { "CusID" });
            DropTable("dbo.TypeTickets");
            DropTable("dbo.Transactions");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
            DropTable("dbo.Cards");
        }
    }
}
