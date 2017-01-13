using Bookstore.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Context.EntitiesConfiguration
{
    class BookStateConfiguration : EntityTypeConfiguration<BookState>
    {
        public BookStateConfiguration()
        {
            ToTable("BooksStates");

            HasKey(bs => bs.BookStateId);

            Property(bs => bs.Description).HasMaxLength(50);
        }
    }
}
