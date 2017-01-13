namespace Bookstore.Context.Migrations
{
    using Bookstore.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Bookstore.Context.BookstoreDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Bookstore.Context.BookstoreDbContext context)
        {
            context.Authors.AddOrUpdate(
                new Author { Name = "Dino Esposito" },
                new Author { Name = "Jhon Sharp" }
                );


            context.BookLevels.AddOrUpdate(
               new BookLevel { BookLevelId = 1, Description = "Basic" },
               new BookLevel { BookLevelId = 2, Description = "Intermediate" },
               new BookLevel { BookLevelId = 3, Description = "Advanced" }
               );

            context.BookStates.AddOrUpdate(
               new BookState { BookStateId = 1, Description = "New" },
               new BookState { BookStateId = 2, Description = "Sale" },
               new BookState { BookStateId = 3, Description = "Reserved" }
               );

            context.Books.AddOrUpdate(
                new Book { BookId = 1, AuthorId = 1, Title = "C# Advanced", Description = "C# Advanced Description", Price = 69, BookLevelId = 3, BookStateId = 2 },
                new Book { BookId = 2, AuthorId = 1, Title = "C# Intermediate", Description = "C# Intermediate Description", Price = 49, BookLevelId = 2, BookStateId = 2 },
                new Book { BookId = 3, AuthorId = 1, Title = "Clean Code", Description = "Clean Code Description", Price = 99, BookLevelId = 2, BookStateId = 2 }
                );
        }
    }
}
