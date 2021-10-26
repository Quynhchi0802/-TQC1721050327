namespace ĐTQC1721050327.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_lecture : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Persons",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 128),
                        PersonName = c.String(),
                    })
                .PrimaryKey(t => t.PersonID);
            
            CreateTable(
                "dbo.Lectures",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 128),
                        Faculty = c.String(),
                        Department = c.String(),
                    })
                .PrimaryKey(t => t.PersonID)
                .ForeignKey("dbo.Persons", t => t.PersonID)
                .Index(t => t.PersonID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 128),
                        Univercity = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.PersonID)
                .ForeignKey("dbo.Persons", t => t.PersonID)
                .Index(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "PersonID", "dbo.Persons");
            DropForeignKey("dbo.Lectures", "PersonID", "dbo.Persons");
            DropIndex("dbo.Students", new[] { "PersonID" });
            DropIndex("dbo.Lectures", new[] { "PersonID" });
            DropTable("dbo.Students");
            DropTable("dbo.Lectures");
            DropTable("dbo.Persons");
        }
    }
}
