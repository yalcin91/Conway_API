using Conway.Core.Model;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway.Data.Seeds
{
    public class JTI_Tabac_Seed : IEntityTypeConfiguration<JTI_Tabac>
    {
        public void Configure(EntityTypeBuilder<JTI_Tabac> builder)
        {
            builder.HasData(
                new JTI_Tabac(1, 238384, "WINSTON RYO BLOND/30G", 5410446008259, "JTI", "", 1, 1, 1, 1, "Tabac", ""),
                 new JTI_Tabac(2, 2622, "WINSTON RYO ORIGINAL/40G", 5411808067860, "JTI", "", 1, 1, 1, 1, "Tabac", "")
                );
        }
    }
}
