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
    public class BAT_Cigarette_Seed : IEntityTypeConfiguration<BAT_Cigarette>
    {
        public void Configure(EntityTypeBuilder<BAT_Cigarette> builder)
        {
            builder.HasData(
                new BAT_Cigarette(1, 1576, "JOHNSON RS FILTER SOFT/25", 54039230, "BAT", "M", 0, 0, 0, 0, "Cigarette", "red"),
                new BAT_Cigarette(2, 237531, "KENT CORE WHITE/20", 54029644, "BAT", "S", 0.5, 0.5, 0.5, 0.5, "Cigarette", ""),
                new BAT_Cigarette(3, 242071, "KENT SURROUND LONG/20", 54029101, "BAT", "S", 0.5, 0.5, 0.5, 0.5, "Cigarette", ""),
                new BAT_Cigarette(4, 243809, "KENT SURROUND BROWN/20", 54029170, "BAT", "S", 1, 1, 1, 1, "Cigarette", ""),
                new BAT_Cigarette(5, 374350, "KENT SURROUND BROWN/23", 54003859, "BAT", "M", 0, 0, 0, 0, "Cigarette", "red"),

                new BAT_Cigarette(6, 393308, "KENT SURROUND BROWN/30", 54003873, "BAT", "L", 1, 1, 1, 1, "Cigarette", "yellow"),
                new BAT_Cigarette(7, 410942, "KENT SURROUND BROWN/36", 54003811, "BAT", "XXL", 1, 1, 0, 1, "Cigarette", "green"),
                new BAT_Cigarette(8, 1490, "LUCKY BLUE SOFT/25", 54039018, "BAT", "M", 1, 1, 0, 1, "Cigarette", ""),
                new BAT_Cigarette(9, 1493, "LUCKY RED SOFT/25", 54039001, "BAT", "M", 1, 1, 1, 1, "Cigarette", ""),
                new BAT_Cigarette(10, 242098, "LUCKY STRIKE AUTHENTIC RED/20", 54029057, "BAT", "S", 1, 1, 1, 1, "Cigarette", ""),

                new BAT_Cigarette(11, 243906, "LUCKY STRIKE AUTHENTIC BLUE/20", 54029064, "BAT", "S", 0, 0, 0, 0, "Cigarette", "red"),
                new BAT_Cigarette(12, 242101, "LUCKY STRIKE RED/20", 54029040, "BAT", "S", 1, 1, 1, 1, "Cigarette", ""),
                new BAT_Cigarette(13, 335029, "LUCKY STRIKE RED M/25", 54003651, "BAT", "M", 0.5, 0, 0, 0, "Cigarette", "red"),
                new BAT_Cigarette(14, 393924, "LUCKY STRIKE RED 30", 54029200, "BAT", "XL", 1, 1, 1, 1, "Cigarette", ""),
                new BAT_Cigarette(15, 410969, "LUCKY STRIKE RED 36", 54120006, "BAT", "XXL", 1, 1, 0.5, 1, "Cigarette", "green"),

                new BAT_Cigarette(16, 242152, "PALL MALL BLUE S/20", 54039261, "BAT", "S", 1, 1, 0, 0, "Cigarette", "green"),
                new BAT_Cigarette(17, 411124, "PALL MALL BLUE M/23", 54002760, "BAT", "M", 0.5, 0.5, 0.5, 0, "Cigarette", "red"),
                new BAT_Cigarette(18, 411140, "PALL MALL BLUE/33", 54004573, "BAT", "XL", 1, 1, 1, 1, "Cigarette", "yellow"),
                new BAT_Cigarette(19, 243914, "PALL MALL FLOW/20 ", 40318257, "BAT", "S", 1, 1, 1, 0, "Cigarette", "red"),
                new BAT_Cigarette(20, 242144, "PALL MALL RED/20", 54029880, "BAT", "S", 1, 1, 1, 1, "Cigarette", ""),

                new BAT_Cigarette(21, 411175, "PALL MALL RED M/23", 54002777, "BAT", "M", 0.5, 0, 0.5, 0.5, "Cigarette", "red"),
                new BAT_Cigarette(22, 411159, "PALL MALL RED/33", 54003958, "BAT", "XL", 0.5, 1, 0.5, 1, "Cigarette", ""),
                new BAT_Cigarette(23, 411167, "PALL MALL RED/37", 54002746, "BAT", "XXL", 1, 1, 1, 1, "Cigarette", ""),
                new BAT_Cigarette(24, 411183, "PALL MALL RED/47", 54004580, "BAT", "XXXL", 1, 1, 1, 1, "Cigarette", ""),
                new BAT_Cigarette(25, 406848, "P.STUYVESANT RED KS/22", 54002692, "BAT", "M", 0.5, 0, 0.5, 0, "Cigarette", ""),

                new BAT_Cigarette(26, 124478, "VOGUE BLUE SUPERSLIMS/20", 59026495, "BAT", "S", 1, 1, 1, 1, "Cigarette", "green")
                );
        }
    }
}
