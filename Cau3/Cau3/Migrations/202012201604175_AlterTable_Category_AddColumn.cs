namespace Cau3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTable_Category_AddColumn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Note = c.String(),
                        DateCreate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostID = c.Int(nullable: false, identity: true),
                        Tille = c.String(),
                        Content = c.String(),
                        Image = c.String(),
                        Note = c.String(),
                        CategoryID = c.String(),
                        Category_CategoryID = c.Int(),
                    })
                .PrimaryKey(t => t.PostID)
                .ForeignKey("dbo.Categories", t => t.Category_CategoryID)
                .Index(t => t.Category_CategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "Category_CategoryID", "dbo.Categories");
            DropIndex("dbo.Posts", new[] { "Category_CategoryID" });
            DropTable("dbo.Posts");
            DropTable("dbo.Categories");
        }
    }
}
