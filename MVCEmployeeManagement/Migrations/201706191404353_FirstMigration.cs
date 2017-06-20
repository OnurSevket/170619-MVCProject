namespace MVCEmployeeManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50, unicode: false),
                        LastName = c.String(nullable: false, maxLength: 50, unicode: false),
                        HireDate = c.DateTime(storeType: "date"),
                        DateOfBirth = c.DateTime(storeType: "date"),
                        Phone = c.String(maxLength: 20),
                        Email = c.String(maxLength: 100),
                        Gender = c.Boolean(nullable: false),
                        DepartmentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Department", t => t.DepartmentID)
                .Index(t => t.DepartmentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee", "DepartmentID", "dbo.Department");
            DropIndex("dbo.Employee", new[] { "DepartmentID" });
            DropTable("dbo.Employee");
            DropTable("dbo.Department");
        }
    }
}
