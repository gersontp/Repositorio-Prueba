using Bookstore.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Context.EntitiesConfiguration
{
    class BookLevelConfiguration : EntityTypeConfiguration<BookLevel>
    {
        public BookLevelConfiguration()
        {
            ToTable("BooksLevels");

            HasKey(bl => bl.BookLevelId);

            Property(bl => bl.Description).HasMaxLength(50);

        }
    }
}
