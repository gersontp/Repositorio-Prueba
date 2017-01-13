namespace Bookstore.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        AuthorId = c.Int(nullable: false),
                        Title = c.String(maxLength: 255),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BookLevelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookId)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.BookLevels", t => t.BookLevelId, cascadeDelete: true)
                .Index(t => t.AuthorId)
                .Index(t => t.BookLevelId);
            
            CreateTable(
                "dbo.BookLevels",
                c => new
                    {
                        BookLevelId = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.BookLevelId);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        TagId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.TagId);
            
            CreateTable(
                "dbo.BookTags",
                c => new
                    {
                        Book_BookId = c.Int(nullable: false),
                        Tag_TagId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Book_BookId, t.Tag_TagId })
                .ForeignKey("dbo.Books", t => t.Book_BookId, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.Tag_TagId, cascadeDelete: true)
                .Index(t => t.Book_BookId)
                .Index(t => t.Tag_TagId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookTags", "Tag_TagId", "dbo.Tags");
            DropForeignKey("dbo.BookTags", "Book_BookId", "dbo.Books");
            DropForeignKey("dbo.Books", "BookLevelId", "dbo.BookLevels");
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropIndex("dbo.BookTags", new[] { "Tag_TagId" });
            DropIndex("dbo.BookTags", new[] { "Book_BookId" });
            DropIndex("dbo.Books", new[] { "BookLevelId" });
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropTable("dbo.BookTags");
            DropTable("dbo.Tags");
            DropTable("dbo.BookLevels");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
