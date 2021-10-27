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
    public class ITB_Cigarette_Seed : IEntityTypeConfiguration<ITB_Cigarette>
    {
        public void Configure(EntityTypeBuilder<ITB_Cigarette> builder)
        {
            builder.HasData(
                new ITB_Cigarette(1, 1473, "BASTOS ROUGE FILTER/25", 54030022, "ITB", "", 1, 1, 1, 0, "Cigarette", ""),
                new ITB_Cigarette(2, 252689, "GAULOISES BLONDES BLUE/20", 4030600123331, "ITB", "", 1, 1, 1, 1, "Cigarette", ""),
                new ITB_Cigarette(3, 375756, "GAULOISES BLONDES BLUE L/25", 4030600236277, "ITB", "", 1, 1, 1, 1, "Cigarette", "yellow"),
                new ITB_Cigarette(4, 408263, "GAULOISES BLONDES BLUE XL/29", 4030600274262, "ITB", "", 1, 1, 1, 1, "Cigarette", "yellow"),
                new ITB_Cigarette(5, 1440, "GAULOISES BRUN BLEU FILTRE/20", 30002388, "ITB", "", 0, 0, 0, 1, "Cigarette", ""),

                new ITB_Cigarette(6, 252719, "JPS BLUE STREAM/20", 4030600123423, "ITB", "", 1, 1, 1, 1, "Cigarette", ""),
                new ITB_Cigarette(7, 252700, "JPS RED KS/20", 4030600123393, "ITB", "", 1, 1, 1, 1, "Cigarette", ""),
                new ITB_Cigarette(8, 375799, "JPS RED/25", 4030600236390, "ITB", "", 1, 1, 1, 1, "Cigarette", "yellow"),
                new ITB_Cigarette(9, 408328, "JPS RED/30", 4030600274323, "ITB", "", 1, 1, 1, 1, "Cigarette", "yellow"),
                new ITB_Cigarette(10, 408336, "JPS RED/40", 4030600274200, "ITB", "", 1, 1, 1, 1, "Cigarette", "yellow")
                );
        }
    }
    /*
1	1473	BASTOS ROUGE FILTER/25        	54030022    	ITB		1	1	1		Cigarette
2	252689	GAULOISES BLONDES BLUE/20     	4030600123331	ITB		1	1	1	1	Cigarette
3	375756	GAULOISES BLONDES BLUE L/25 	4030600236277	ITB		1	1	1	1	Cigarette
4	408263	GAULOISES BLONDES BLUE XL/29 	4030600274262	ITB		1	1	1	1	Cigarette
5	1440	GAULOISES BRUN BLEU FILTRE/20 	30002388	    ITB		 	 	 	1	Cigarette

6	252719	JPS BLUE STREAM/20	            4030600123423	ITB		1	1	1	1	Cigarette
7	252700	JPS RED KS/20                 	4030600123393	ITB		1	1	1	1	Cigarette
8	375799	JPS RED/25	                    4030600236390	ITB		1	1	1	1	Cigarette
9	408328	JPS RED/30	                    4030600274323	ITB		1	1	1	1	Cigarette
10	408336	JPS RED/40	                    4030600274200	ITB		1	1	1	1	Cigarette

     */
}
