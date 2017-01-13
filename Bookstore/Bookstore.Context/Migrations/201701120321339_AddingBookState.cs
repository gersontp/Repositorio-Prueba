namespace Bookstore.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingBookState : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.BookLevels", newName: "BooksLevels");
            RenameTable(name: "dbo.BookTags", newName: "BooksTags");
            CreateTable(
                "dbo.BooksStates",
                c => new
                    {
                        BookStateId = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.BookStateId);
            
            AddColumn("dbo.Books", "BookStateId", c => c.Int(nullable: false));
            CreateIndex("dbo.Books", "BookStateId");
            AddForeignKey("dbo.Books", "BookStateId", "dbo.BooksStates", "BookStateId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "BookStateId", "dbo.BooksStates");
            DropIndex("dbo.Books", new[] { "BookStateId" });
            DropColumn("dbo.Books", "BookStateId");
            DropTable("dbo.BooksStates");
            RenameTable(name: "dbo.BooksTags", newName: "BookTags");
            RenameTable(name: "dbo.BooksLevels", newName: "BookLevels");
        }
    }
}
