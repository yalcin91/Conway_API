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
    public class PMI_Cigarette_Seed : IEntityTypeConfiguration<PMI_Cigarette>
    {
        public void Configure(EntityTypeBuilder<PMI_Cigarette> builder)
        {
            builder.HasData(
                new PMI_Cigarette(1, 250546, "CHESTERFIELD RED/20", 54140660, "PMI", "", 1, 1, 1, 1, "Cigarette", ""),
                new PMI_Cigarette(2, 370339, "CHESTERFIELD RED/23", 54141681, "PMI", "", 0, 0, 0, 0, "Cigarette", "red"),
                new PMI_Cigarette(3, 370363, "CHESTERFIELD RED/34", 54002401, "PMI", "", 0, 0, 0, 0, "Cigarette", "red"),
                new PMI_Cigarette(4, 408794, "CHESTERFIELD RED XL/31", 54014534, "PMI", "", 1, 1, 1, 1, "Cigarette", "green"),
                new PMI_Cigarette(5, 408786, "CHESTERFIELD RED BIG/47", 54014510, "PMI", "", 1, 1, 1, 1, "Cigarette", "green"),

                new PMI_Cigarette(6, 246514, "L&M BLUE/20", 54140424, "PMI", "", 1, 1, 1, 1, "Cigarette", ""),
                new PMI_Cigarette(7, 367567, "L&M BLUE M/23", 54002364, "PMI", "", 0, 0, 0, 0, "Cigarette", "red"),
                new PMI_Cigarette(8, 367540, "L&M BLUE/27", 54002388, "PMI", "", 0, 0, 0, 0, "Cigarette", "red"),
                new PMI_Cigarette(9, 371874, "L&M BLUE/32", 54002418, "PMI", "", 1, 1, 1, 1, "Cigarette", "green"),
                new PMI_Cigarette(10, 246506, "L&M ORIGINAL/20", 54140431, "PMI", "", 1, 1, 1, 1, "Cigarette", ""),

                new PMI_Cigarette(11, 408808, "L&M ORIGINAL M/23", 54014688, "PMI", "", 1, 1, 1, 1, "Cigarette", "yellow"),
                new PMI_Cigarette(12, 408824, "L&M ORIGINAL L/27", 54014541, "PMI", "", 1, 1, 1, 1, "Cigarette", "yellow"),
                new PMI_Cigarette(13, 382744, "L&M ORIGINAL XL/31", 54014459, "PMI", "", 1, 1, 1, 1, "Cigarette", "yellow"),
                new PMI_Cigarette(14, 371920, "L&m Orignal XXL/39", 54141643, "PMI", "", 1, 1, 1, 1, "Cigarette", ""),
                new PMI_Cigarette(15, 406791, "L&M ORIGINAL BIG/48", 54014657, "PMI", "", 1, 1, 1, 1, "Cigarette", "green"),

                new PMI_Cigarette(16, 367575, "L&M SILVER/23", 54002395, "PMI", "", 0, 0, 0, 0, "Cigarette", "red"),
                new PMI_Cigarette(17, 247464, "MARLBORO FINE TOUCH/20", 54140875, "PMI", "", 1, 1, 1, 1, "Cigarette", ""),
                new PMI_Cigarette(18, 247456, "MARLBORO GOLD/20", 54140851, "PMI", "", 1, 1, 1, 1, "Cigarette", ""),
                new PMI_Cigarette(19, 371947, "MARLBORO GOLD/23", 54141520, "PMI", "", 0, 0, 0, 0, "Cigarette", "red"),
                new PMI_Cigarette(20, 407690, "MARLBORO GOLD L 27", 54014633, "PMI", "", 1, 1, 1, 1, "Cigarette", "green"),

                new PMI_Cigarette(21, 371939, "MARLBORO GOLD/30", 54141452, "PMI", "", 0, 0, 0, 0, "Cigarette", "red"),
                new PMI_Cigarette(22, 416762, "MARLBORO GOLD XXL/37", 54002326, "PMI", "", 1, 1, 1, 1, "Cigarette", "green"),
                new PMI_Cigarette(23, 384151, "Marlboro bright/20", 54014404, "PMI", "", 0, 0, 0, 0, "Cigarette", "red"),
                new PMI_Cigarette(24, 246468, "MARLBORO PRIME/20", 54141421, "PMI", "", 0, 0, 0, 0, "Cigarette", "red"),
                new PMI_Cigarette(25, 250511, "MARLBORO RED 100/20", 54140806, "PMI", "", 0, 0, 0, 0, "Cigarette", "red"),

                new PMI_Cigarette(26, 251895, "MARLBORO RED/20", 54140813, "PMI", "", 1, 1, 1, 1, "Cigarette", ""),
                new PMI_Cigarette(27, 370347, "MARLBORO RED/23", 54002487, "PMI", "", 1, 1, 1, 1, "Cigarette", ""),
                new PMI_Cigarette(28, 333441, "MARLBORO RED/27", 54002142, "PMI", "", 1, 1, 1, 1, "Cigarette", ""),
                new PMI_Cigarette(29, 371807, "MARLBORO RED/37", 54141506, "PMI", "", 1, 1, 1, 1, "Cigarette", "green"),
                new PMI_Cigarette(30, 416789, "MARLBORO RED BIG 48", 54014503, "PMI", "", 1, 1, 1, 1, "Cigarette", "green")
                );
        }
    }
    /*
1	250546	CHESTERFIELD RED/20           	54140660	PMI		1	1	1	1	Cigarette
2	370339	CHESTERFIELD RED/23         	54141681	PMI		0	 	0	0	Cigarette
3	370363	CHESTERFIELD RED/34           	54002401	PMI		0	0	0	0	Cigarette
4	408794	CHESTERFIELD RED XL/31	        54014534	PMI		1	1	1	1	Cigarette
5	408786	CHESTERFIELD RED BIG/47	        54014510	PMI		1	1	1	1	Cigarette

6	246514	L&M BLUE/20                   	54140424	PMI		1	1	1	1	Cigarette
7	367567	L&M BLUE M/23                 	54002364	PMI		0	0	0	0	Cigarette
8	367540	L&M BLUE/27                  	54002388	PMI		0	0	0	0	Cigarette
9	371874	L&M BLUE/32                 	54002418	PMI		1	1	1	1	Cigarette
10	246506	L&M ORIGINAL/20               	54140431	PMI		1	1	1	1	Cigarette

11	408808	L&M ORIGINAL M/23	            54014688	PMI		1	1	1	1	Cigarette
12	408824	L&M ORIGINAL L/27	            54014541	PMI		1	1	1	1	Cigarette
13	382744	L&M ORIGINAL XL/31	            54014459	PMI		1	1	1	1	Cigarette
14	371920	L&m Orignal XXL/39	            54141643	PMI		1	1	1	1	Cigarette
15	406791	L&M ORIGINAL BIG/48           	54014657			1	1	1	1	Cigarette

16	367575	L&M SILVER/23               	54002395	PMI		0	0	0	0	Cigarette
17	247464	MARLBORO FINE TOUCH/20        	54140875	PMI		1	1	1	1	Cigarette
18	247456	MARLBORO GOLD/20              	54140851	PMI		1	1	1	1	Cigarette
19	371947	MARLBORO GOLD/23             	54141520	PMI		0	0	0	0	Cigarette
20	407690	MARLBORO GOLD L 27	            54014633			1	1	1	1	Cigarette

21	371939	MARLBORO GOLD/30             	54141452	PMI		0	0	0	0	Cigarette
22	416762	MARLBORO GOLD XXL/37	        54002326	PMI		1	1	1	1	Cigarette
23	384151	Marlboro bright/20	            54014404	PMI		0	0	0	0	Cigarette
24	246468	MARLBORO PRIME/20             	54141421	PMI		0	0	0	0	Cigarette
25	250511	MARLBORO RED 100/20           	54140806	PMI		0	0	0	0	Cigarette

26	251895	MARLBORO RED/20               	54140813	PMI		1	1	1	1	Cigarette
27	370347	MARLBORO RED/23              	54002487	PMI		1	1	1	1	Cigarette
28	333441	MARLBORO RED/27              	54002142	PMI		1	1	1	1	Cigarette
29	371807	MARLBORO RED/37	                54141506	PMI		1	1	1	1	Cigarette
30	416789	MARLBORO RED BIG 48	            54014503	PMI		1	1	1	1	Cigarette

     */
}
