namespace Notebook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NIP = c.Int(nullable: false),
                        Address = c.String(),
                        City = c.String(),
                        Code = c.Int(nullable: false),
                        Phone = c.Int(nullable: false),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Job = c.String(),
                        Phone = c.Int(nullable: false),
                        Mobile = c.Int(nullable: false),
                        Company_Id = c.Int(),
                    })
                .PrimaryKey(t => t.PersonId)
                .ForeignKey("dbo.Companies", t => t.Company_Id)
                .Index(t => t.Company_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "Company_Id", "dbo.Companies");
            DropIndex("dbo.People", new[] { "Company_Id" });
            DropTable("dbo.People");
            DropTable("dbo.Companies");
        }
    }
}
