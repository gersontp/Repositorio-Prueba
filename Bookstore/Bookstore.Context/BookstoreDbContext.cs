using Bookstore.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Context.EntitiesConfiguration;

namespace Bookstore.Context
{
    public class BookstoreDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<BookLevel> BookLevels { get; set; }

        public DbSet<BookState> BookStates { get; set; }

        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AuthorConfiguration());

            modelBuilder.Configurations.Add(new BookConfiguration());

            modelBuilder.Configurations.Add(new BookLevelConfiguration());

            modelBuilder.Configurations.Add(new BookStateConfiguration());

            modelBuilder.Configurations.Add(new TagConfiguration());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
