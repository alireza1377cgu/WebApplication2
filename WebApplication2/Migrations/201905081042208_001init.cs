namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _001init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.fields",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        caption = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BrandName = c.String(),
                        ModeINO = c.String(),
                        Description = c.String(),
                        fieldId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.fields", t => t.fieldId, cascadeDelete: true)
                .Index(t => t.fieldId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.products", "fieldId", "dbo.fields");
            DropIndex("dbo.products", new[] { "fieldId" });
            DropTable("dbo.products");
            DropTable("dbo.fields");
        }
    }
}
