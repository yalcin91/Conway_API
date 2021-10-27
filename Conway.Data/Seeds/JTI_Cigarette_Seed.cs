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
    public class JTI_Cigarette_Seed : IEntityTypeConfiguration<JTI_Cigarette>
    {
        public void Configure(EntityTypeBuilder<JTI_Cigarette> builder)
        {
            builder.HasData(
                new JTI_Cigarette(1, 238295, "CAMEL BLUE S/20", 54043206, "JTI", "S", 1, 1, 1, 0, "Cigarette", ""),
                new JTI_Cigarette(2, 176605, "CAMEL BLUE BOX/26", 5410446006767, "JTI", "M", 0, 0, 0, 0, "Cigarette", "red"),
                new JTI_Cigarette(3, 294519, "CAMEL BLUE XXL/35", 5410446012355, "JTI", "XXL", 1, 1, 1, 1, "Cigarette", "green"),
                new JTI_Cigarette(4, 238279, "CAMEL YELLOW S/20", 54043213, "JTI", "S", 1, 1, 1, 1, "Cigarette", ""),
                new JTI_Cigarette(5, 176591, "CAMEL YELLOW L/26", 5410446006736, "JTI", "L", 1, 1, 1, 1, "Cigarette", ""),

                new JTI_Cigarette(6, 267163, "CAMEL YELLOW XXL/35", 54043114, "JTI", "XXL", 1, 1, 1, 1, "Cigarette", ""),
                new JTI_Cigarette(7, 238252, "CAMEL ESSENTIAL BROWN/20", 5410446008938, "JTI", "X", 0, 0, 0, 1, "Cigarette", "red"),
                new JTI_Cigarette(8, 238333, "WINSTON BLUE/20", 54043237, "JTI", "S", 1, 1, 1, 1, "Cigarette", "green"),
                new JTI_Cigarette(9, 238325, "WINSTON CLASSIC/20 ", 54043138, "JTI", "S", 1, 1, 1, 1, "Cigarette", ""),
                new JTI_Cigarette(10, 267198, "WINSTON CLASSIC GIGA/35", 54043121, "JTI", "XXL", 1, 1, 1, 1, "Cigarette", "")
                );
        }
    }
}
