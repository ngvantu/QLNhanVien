namespace AutoCheckTicketSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        FullName = c.String(unicode: false),
                        Birthday = c.DateTime(nullable: false, precision: 0),
                        Indentity = c.String(unicode: false),
                        ImageID = c.String(unicode: false),
                        IsUsed = c.Boolean(nullable: false),
                        Role = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
