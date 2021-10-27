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
    public class BAT_Tabac_Config : IEntityTypeConfiguration<BAT_Tabac>
    {
        public void Configure(EntityTypeBuilder<BAT_Tabac> builder)
        {
            builder.HasAlternateKey(x => x.Id);
            builder.Property(x => x.Ref);
            builder.Property(x => x.Product);
            builder.Property(x => x.Eancode);
            builder.Property(x => x.Fabrikant);
            builder.Property(x => x.Size);
            builder.Property(x => x.Nielsen1);
            builder.Property(x => x.Nielsen2);
            builder.Property(x => x.Nielsen3);
            builder.Property(x => x.Nielsen4);
            builder.Property(x => x.Groupe);
            builder.Property(x => x.Color);
        }
    }
}
