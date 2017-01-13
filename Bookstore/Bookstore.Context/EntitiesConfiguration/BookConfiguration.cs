using Bookstore.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Context.EntitiesConfiguration
{
    class BookConfiguration : EntityTypeConfiguration<Book>
    {
        public BookConfiguration()
        {
            ToTable("Books");

            HasKey(b => b.BookId);

            Property(b => b.Title).HasMaxLength(255);

            Property(b => b.Description).HasMaxLength(8000);

            //Configuro relacion Book - BookLevel
            HasRequired(b => b.BookLevel)
                .WithMany(bl => bl.Books)
                .HasForeignKey(b => b.BookLevelId);

            //Configuro relacion Book - BookState
            HasRequired(b => b.BookState)
                .WithMany(bl => bl.Books)
                .HasForeignKey(b => b.BookStateId);

            //Configuro relacion Book - Author
            HasRequired(a => a.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId);

            //Configuro relacion Book - Tag
            HasMany(b => b.Tags)
                .WithMany(t => t.Books)
                .Map(bt => bt.ToTable("BooksTags"));
        }
    }
}
