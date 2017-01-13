using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Bookstore.Entities;


namespace Bookstore.Context.EntitiesConfiguration
{
    class AuthorConfiguration : EntityTypeConfiguration<Author>
    {
        public AuthorConfiguration()
        {
            //Configuro el nombre de la tabla en la base de datos
            ToTable("Authors");

            //Configuro la llave primaria de la tabla Authors
            HasKey(a => a.AuthorId);

            //Configuro la longitud maxima del campo Name
            Property(a => a.Name).HasMaxLength(255);
        }
    }
}
