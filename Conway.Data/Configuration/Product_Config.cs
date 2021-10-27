using Conway.Core.Model;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway.Data.Configuration
{
    public class Product_Config : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasAlternateKey(x => x.Id);
            builder.Property(x => x.Naam);
            builder.Property(x => x.Activatie);
            builder.Property(x => x.Fabrikant);
            builder.Property(x => x.Hoogte);
            builder.Property(x => x.Breedte);
            builder.Property(x => x.Diepte);
            builder.Property(x => x.Inhoud);
            builder.Property(x => x.Eancode);
            builder.Property(x => x.Prijs);
        }
    }
}
