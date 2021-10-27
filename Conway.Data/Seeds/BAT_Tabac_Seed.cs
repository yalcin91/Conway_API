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
    public class BAT_Tabac_Seed : IEntityTypeConfiguration<BAT_Tabac>
    {
        public void Configure(EntityTypeBuilder<BAT_Tabac> builder)
        {
            builder.HasData(
                new BAT_Tabac(1, 2506, "AJJA 17 BLOND ROUGE/50G", 54039285, "BAT", "", 0, 1, 1, 1, "Tabac", ""),
                new BAT_Tabac(2, 2503, "AJJA 17 CORSE BLEU/50G", 54039292, "BAT", "", 1, 1, 1, 1, "Tabac", ""),
                new BAT_Tabac(3, 233773, "LUCKY STRIKE 100%US BL RED/30G", 54039360, "BAT", "", 1, 1, 1, 1, "Tabac", ""),
                new BAT_Tabac(4, 2486, "LUCKY STRIKE BLUE/50G", 54039384, "BAT", "", 1, 1, 1, 1, "Tabac", ""),
                new BAT_Tabac(5, 2483, "LUCKY STRIKE RED/50G", 54039377, "BAT", "", 1, 1, 1, 1, "Tabac", ""),

                new BAT_Tabac(6, 218731, "PALL MALL ROLL RED/30G", 54039490, "BAT", "", 1, 1, 1, 1, "Tabac", "")
                );
        }
    }
}
