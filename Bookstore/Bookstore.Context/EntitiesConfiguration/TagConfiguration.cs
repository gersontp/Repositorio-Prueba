using Bookstore.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Context.EntitiesConfiguration
{
    class TagConfiguration : EntityTypeConfiguration<Tag>
    {

        public TagConfiguration()
        {
            ToTable("Tags");

            HasKey(t => t.TagId);

            Property(t => t.Name).HasMaxLength(50);
        }
    }
}
