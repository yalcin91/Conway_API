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
    public class ITB_Tabac_Seed : IEntityTypeConfiguration<ITB_Tabac>
    {
        public void Configure(EntityTypeBuilder<ITB_Tabac> builder)
        {
            builder.HasData(
                 new ITB_Tabac(1, 2600, "DRUM ORIGINAL/50G", 8710900061002, "ITB", "", 1, 1, 0, 0, "Tabac", ""),
                 new ITB_Tabac(2, 2457, "GAULOISES CAPORAL/50G (ZWAAR)", 5411808067860, "ITB", "", 0, 0, 1, 1, "Tabac", "")
                );
        }
    }
}
