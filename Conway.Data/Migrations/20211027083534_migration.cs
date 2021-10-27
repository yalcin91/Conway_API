using Microsoft.EntityFrameworkCore.Migrations;

namespace Conway.Data.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BAT_Cigarettes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ref = table.Column<int>(type: "int", nullable: false),
                    Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eancode = table.Column<long>(type: "bigint", nullable: false),
                    Fabrikant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nielsen1 = table.Column<double>(type: "float", nullable: false),
                    Nielsen2 = table.Column<double>(type: "float", nullable: false),
                    Nielsen3 = table.Column<double>(type: "float", nullable: false),
                    Nielsen4 = table.Column<double>(type: "float", nullable: false),
                    Groupe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BAT_Cigarettes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BAT_Tabacs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ref = table.Column<int>(type: "int", nullable: false),
                    Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eancode = table.Column<long>(type: "bigint", nullable: false),
                    Fabrikant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nielsen1 = table.Column<double>(type: "float", nullable: false),
                    Nielsen2 = table.Column<double>(type: "float", nullable: false),
                    Nielsen3 = table.Column<double>(type: "float", nullable: false),
                    Nielsen4 = table.Column<double>(type: "float", nullable: false),
                    Groupe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BAT_Tabacs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ITB_Cigarettes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ref = table.Column<int>(type: "int", nullable: false),
                    Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eancode = table.Column<long>(type: "bigint", nullable: false),
                    Fabrikant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nielsen1 = table.Column<double>(type: "float", nullable: false),
                    Nielsen2 = table.Column<double>(type: "float", nullable: false),
                    Nielsen3 = table.Column<double>(type: "float", nullable: false),
                    Nielsen4 = table.Column<double>(type: "float", nullable: false),
                    Groupe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITB_Cigarettes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ITB_Tabacs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ref = table.Column<int>(type: "int", nullable: false),
                    Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eancode = table.Column<long>(type: "bigint", nullable: false),
                    Fabrikant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nielsen1 = table.Column<double>(type: "float", nullable: false),
                    Nielsen2 = table.Column<double>(type: "float", nullable: false),
                    Nielsen3 = table.Column<double>(type: "float", nullable: false),
                    Nielsen4 = table.Column<double>(type: "float", nullable: false),
                    Groupe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITB_Tabacs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JTI_Cigarettes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ref = table.Column<int>(type: "int", nullable: false),
                    Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eancode = table.Column<long>(type: "bigint", nullable: false),
                    Fabrikant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nielsen1 = table.Column<double>(type: "float", nullable: false),
                    Nielsen2 = table.Column<double>(type: "float", nullable: false),
                    Nielsen3 = table.Column<double>(type: "float", nullable: false),
                    Nielsen4 = table.Column<double>(type: "float", nullable: false),
                    Groupe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JTI_Cigarettes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JTI_Tabacs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ref = table.Column<int>(type: "int", nullable: false),
                    Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eancode = table.Column<long>(type: "bigint", nullable: false),
                    Fabrikant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nielsen1 = table.Column<double>(type: "float", nullable: false),
                    Nielsen2 = table.Column<double>(type: "float", nullable: false),
                    Nielsen3 = table.Column<double>(type: "float", nullable: false),
                    Nielsen4 = table.Column<double>(type: "float", nullable: false),
                    Groupe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JTI_Tabacs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PMI_Cigarettes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ref = table.Column<int>(type: "int", nullable: false),
                    Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eancode = table.Column<long>(type: "bigint", nullable: false),
                    Fabrikant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nielsen1 = table.Column<double>(type: "float", nullable: false),
                    Nielsen2 = table.Column<double>(type: "float", nullable: false),
                    Nielsen3 = table.Column<double>(type: "float", nullable: false),
                    Nielsen4 = table.Column<double>(type: "float", nullable: false),
                    Groupe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PMI_Cigarettes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activatie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fabrikant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hoogte = table.Column<double>(type: "float", nullable: false),
                    Breedte = table.Column<double>(type: "float", nullable: false),
                    Diepte = table.Column<double>(type: "float", nullable: false),
                    Inhoud = table.Column<int>(type: "int", nullable: false),
                    Eancode = table.Column<long>(type: "bigint", nullable: false),
                    Prijs = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BAT_Cigarettes",
                columns: new[] { "Id", "Color", "Eancode", "Fabrikant", "Groupe", "Nielsen1", "Nielsen2", "Nielsen3", "Nielsen4", "Product", "Ref", "Size" },
                values: new object[,]
                {
                    { 1L, "red", 54039230L, "BAT", "Cigarette", 0.0, 0.0, 0.0, 0.0, "JOHNSON RS FILTER SOFT/25", 1576, "M" },
                    { 26L, "green", 59026495L, "BAT", "Cigarette", 1.0, 1.0, 1.0, 1.0, "VOGUE BLUE SUPERSLIMS/20", 124478, "S" },
                    { 25L, "", 54002692L, "BAT", "Cigarette", 0.5, 0.0, 0.5, 0.0, "P.STUYVESANT RED KS/22", 406848, "M" },
                    { 24L, "", 54004580L, "BAT", "Cigarette", 1.0, 1.0, 1.0, 1.0, "PALL MALL RED/47", 411183, "XXXL" },
                    { 23L, "", 54002746L, "BAT", "Cigarette", 1.0, 1.0, 1.0, 1.0, "PALL MALL RED/37", 411167, "XXL" },
                    { 21L, "red", 54002777L, "BAT", "Cigarette", 0.5, 0.0, 0.5, 0.5, "PALL MALL RED M/23", 411175, "M" },
                    { 20L, "", 54029880L, "BAT", "Cigarette", 1.0, 1.0, 1.0, 1.0, "PALL MALL RED/20", 242144, "S" },
                    { 19L, "red", 40318257L, "BAT", "Cigarette", 1.0, 1.0, 1.0, 0.0, "PALL MALL FLOW/20 ", 243914, "S" },
                    { 18L, "yellow", 54004573L, "BAT", "Cigarette", 1.0, 1.0, 1.0, 1.0, "PALL MALL BLUE/33", 411140, "XL" },
                    { 17L, "red", 54002760L, "BAT", "Cigarette", 0.5, 0.5, 0.5, 0.0, "PALL MALL BLUE M/23", 411124, "M" },
                    { 16L, "green", 54039261L, "BAT", "Cigarette", 1.0, 1.0, 0.0, 0.0, "PALL MALL BLUE S/20", 242152, "S" },
                    { 15L, "green", 54120006L, "BAT", "Cigarette", 1.0, 1.0, 0.5, 1.0, "LUCKY STRIKE RED 36", 410969, "XXL" },
                    { 14L, "", 54029200L, "BAT", "Cigarette", 1.0, 1.0, 1.0, 1.0, "LUCKY STRIKE RED 30", 393924, "XL" },
                    { 22L, "", 54003958L, "BAT", "Cigarette", 0.5, 1.0, 0.5, 1.0, "PALL MALL RED/33", 411159, "XL" },
                    { 12L, "", 54029040L, "BAT", "Cigarette", 1.0, 1.0, 1.0, 1.0, "LUCKY STRIKE RED/20", 242101, "S" },
                    { 11L, "red", 54029064L, "BAT", "Cigarette", 0.0, 0.0, 0.0, 0.0, "LUCKY STRIKE AUTHENTIC BLUE/20", 243906, "S" },
                    { 10L, "", 54029057L, "BAT", "Cigarette", 1.0, 1.0, 1.0, 1.0, "LUCKY STRIKE AUTHENTIC RED/20", 242098, "S" },
                    { 9L, "", 54039001L, "BAT", "Cigarette", 1.0, 1.0, 1.0, 1.0, "LUCKY RED SOFT/25", 1493, "M" },
                    { 8L, "", 54039018L, "BAT", "Cigarette", 1.0, 1.0, 0.0, 1.0, "LUCKY BLUE SOFT/25", 1490, "M" },
                    { 7L, "green", 54003811L, "BAT", "Cigarette", 1.0, 1.0, 0.0, 1.0, "KENT SURROUND BROWN/36", 410942, "XXL" },
                    { 6L, "yellow", 54003873L, "BAT", "Cigarette", 1.0, 1.0, 1.0, 1.0, "KENT SURROUND BROWN/30", 393308, "L" },
                    { 5L, "red", 54003859L, "BAT", "Cigarette", 0.0, 0.0, 0.0, 0.0, "KENT SURROUND BROWN/23", 374350, "M" },
                    { 4L, "", 54029170L, "BAT", "Cigarette", 1.0, 1.0, 1.0, 1.0, "KENT SURROUND BROWN/20", 243809, "S" },
                    { 3L, "", 54029101L, "BAT", "Cigarette", 0.5, 0.5, 0.5, 0.5, "KENT SURROUND LONG/20", 242071, "S" },
                    { 2L, "", 54029644L, "BAT", "Cigarette", 0.5, 0.5, 0.5, 0.5, "KENT CORE WHITE/20", 237531, "S" },
                    { 13L, "red", 54003651L, "BAT", "Cigarette", 0.5, 0.0, 0.0, 0.0, "LUCKY STRIKE RED M/25", 335029, "M" }
                });

            migrationBuilder.InsertData(
                table: "BAT_Tabacs",
                columns: new[] { "Id", "Color", "Eancode", "Fabrikant", "Groupe", "Nielsen1", "Nielsen2", "Nielsen3", "Nielsen4", "Product", "Ref", "Size" },
                values: new object[,]
                {
                    { 6L, "", 54039490L, "BAT", "Tabac", 1.0, 1.0, 1.0, 1.0, "PALL MALL ROLL RED/30G", 218731, "" },
                    { 5L, "", 54039377L, "BAT", "Tabac", 1.0, 1.0, 1.0, 1.0, "LUCKY STRIKE RED/50G", 2483, "" },
                    { 4L, "", 54039384L, "BAT", "Tabac", 1.0, 1.0, 1.0, 1.0, "LUCKY STRIKE BLUE/50G", 2486, "" },
                    { 3L, "", 54039360L, "BAT", "Tabac", 1.0, 1.0, 1.0, 1.0, "LUCKY STRIKE 100%US BL RED/30G", 233773, "" },
                    { 1L, "", 54039285L, "BAT", "Tabac", 0.0, 1.0, 1.0, 1.0, "AJJA 17 BLOND ROUGE/50G", 2506, "" },
                    { 2L, "", 54039292L, "BAT", "Tabac", 1.0, 1.0, 1.0, 1.0, "AJJA 17 CORSE BLEU/50G", 2503, "" }
                });

            migrationBuilder.InsertData(
                table: "ITB_Cigarettes",
                columns: new[] { "Id", "Color", "Eancode", "Fabrikant", "Groupe", "Nielsen1", "Nielsen2", "Nielsen3", "Nielsen4", "Product", "Ref", "Size" },
                values: new object[,]
                {
                    { 10L, "yellow", 4030600274200L, "ITB", "Cigarette", 1.0, 1.0, 1.0, 1.0, "JPS RED/40", 408336, "" },
                    { 1L, "", 54030022L, "ITB", "Cigarette", 1.0, 1.0, 1.0, 0.0, "BASTOS ROUGE FILTER/25", 1473, "" },
                    { 2L, "", 4030600123331L, "ITB", "Cigarette", 1.0, 1.0, 1.0, 1.0, "GAULOISES BLONDES BLUE/20", 252689, "" },
                    { 3L, "yellow", 4030600236277L, "ITB", "Cigarette", 1.0, 1.0, 1.0, 1.0, "GAULOISES BLONDES BLUE L/25", 375756, "" },
                    { 4L, "yellow", 4030600274262L, "ITB", "Cigarette", 1.0, 1.0, 1.0, 1.0, "GAULOISES BLONDES BLUE XL/29", 408263, "" },
                    { 5L, "", 30002388L, "ITB", "Cigarette", 0.0, 0.0, 0.0, 1.0, "GAULOISES BRUN BLEU FILTRE/20", 1440, "" },
                    { 6L, "", 4030600123423L, "ITB", "Cigarette", 1.0, 1.0, 1.0, 1.0, "JPS BLUE STREAM/20", 252719, "" },
                    { 7L, "", 4030600123393L, "ITB", "Cigarette", 1.0, 1.0, 1.0, 1.0, "JPS RED KS/20", 252700, "" },
                    { 8L, "yellow", 4030600236390L, "ITB", "Cigarette", 1.0, 1.0, 1.0, 1.0, "JPS RED/25", 375799, "" },
                    { 9L, "yellow", 4030600274323L, "ITB", "Cigarette", 1.0, 1.0, 1.0, 1.0, "JPS RED/30", 408328, "" }
                });

            migrationBuilder.InsertData(
                table: "ITB_Tabacs",
                columns: new[] { "Id", "Color", "Eancode", "Fabrikant", "Groupe", "Nielsen1", "Nielsen2", "Nielsen3", "Nielsen4", "Product", "Ref", "Size" },
                values: new object[,]
                {
                    { 2L, "", 5411808067860L, "ITB", "Tabac", 0.0, 0.0, 1.0, 1.0, "GAULOISES CAPORAL/50G (ZWAAR)", 2457, "" },
                    { 1L, "", 8710900061002L, "ITB", "Tabac", 1.0, 1.0, 0.0, 0.0, "DRUM ORIGINAL/50G", 2600, "" }
                });

            migrationBuilder.InsertData(
                table: "JTI_Cigarettes",
                columns: new[] { "Id", "Color", "Eancode", "Fabrikant", "Groupe", "Nielsen1", "Nielsen2", "Nielsen3", "Nielsen4", "Product", "Ref", "Size" },
                values: new object[,]
                {
                    { 1L, "", 54043206L, "JTI", "Cigarette", 1.0, 1.0, 1.0, 0.0, "CAMEL BLUE S/20", 238295, "S" },
                    { 10L, "", 54043121L, "JTI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "WINSTON CLASSIC GIGA/35", 267198, "XXL" },
                    { 8L, "green", 54043237L, "JTI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "WINSTON BLUE/20", 238333, "S" },
                    { 7L, "red", 5410446008938L, "JTI", "Cigarette", 0.0, 0.0, 0.0, 1.0, "CAMEL ESSENTIAL BROWN/20", 238252, "X" },
                    { 6L, "", 54043114L, "JTI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "CAMEL YELLOW XXL/35", 267163, "XXL" },
                    { 9L, "", 54043138L, "JTI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "WINSTON CLASSIC/20 ", 238325, "S" },
                    { 4L, "", 54043213L, "JTI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "CAMEL YELLOW S/20", 238279, "S" },
                    { 3L, "green", 5410446012355L, "JTI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "CAMEL BLUE XXL/35", 294519, "XXL" },
                    { 2L, "red", 5410446006767L, "JTI", "Cigarette", 0.0, 0.0, 0.0, 0.0, "CAMEL BLUE BOX/26", 176605, "M" },
                    { 5L, "", 5410446006736L, "JTI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "CAMEL YELLOW L/26", 176591, "L" }
                });

            migrationBuilder.InsertData(
                table: "JTI_Tabacs",
                columns: new[] { "Id", "Color", "Eancode", "Fabrikant", "Groupe", "Nielsen1", "Nielsen2", "Nielsen3", "Nielsen4", "Product", "Ref", "Size" },
                values: new object[,]
                {
                    { 1L, "", 5410446008259L, "JTI", "Tabac", 1.0, 1.0, 1.0, 1.0, "WINSTON RYO BLOND/30G", 238384, "" },
                    { 2L, "", 5411808067860L, "JTI", "Tabac", 1.0, 1.0, 1.0, 1.0, "WINSTON RYO ORIGINAL/40G", 2622, "" }
                });

            migrationBuilder.InsertData(
                table: "PMI_Cigarettes",
                columns: new[] { "Id", "Color", "Eancode", "Fabrikant", "Groupe", "Nielsen1", "Nielsen2", "Nielsen3", "Nielsen4", "Product", "Ref", "Size" },
                values: new object[,]
                {
                    { 21L, "red", 54141452L, "PMI", "Cigarette", 0.0, 0.0, 0.0, 0.0, "MARLBORO GOLD/30", 371939, "" },
                    { 17L, "", 54140875L, "PMI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "MARLBORO FINE TOUCH/20", 247464, "" },
                    { 18L, "", 54140851L, "PMI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "MARLBORO GOLD/20", 247456, "" },
                    { 19L, "red", 54141520L, "PMI", "Cigarette", 0.0, 0.0, 0.0, 0.0, "MARLBORO GOLD/23", 371947, "" },
                    { 20L, "green", 54014633L, "PMI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "MARLBORO GOLD L 27", 407690, "" },
                    { 22L, "green", 54002326L, "PMI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "MARLBORO GOLD XXL/37", 416762, "" },
                    { 28L, "", 54002142L, "PMI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "MARLBORO RED/27", 333441, "" },
                    { 24L, "red", 54141421L, "PMI", "Cigarette", 0.0, 0.0, 0.0, 0.0, "MARLBORO PRIME/20", 246468, "" },
                    { 25L, "red", 54140806L, "PMI", "Cigarette", 0.0, 0.0, 0.0, 0.0, "MARLBORO RED 100/20", 250511, "" },
                    { 26L, "", 54140813L, "PMI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "MARLBORO RED/20", 251895, "" },
                    { 27L, "", 54002487L, "PMI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "MARLBORO RED/23", 370347, "" },
                    { 16L, "red", 54002395L, "PMI", "Cigarette", 0.0, 0.0, 0.0, 0.0, "L&M SILVER/23", 367575, "" },
                    { 23L, "red", 54014404L, "PMI", "Cigarette", 0.0, 0.0, 0.0, 0.0, "Marlboro bright/20", 384151, "" },
                    { 15L, "green", 54014657L, "PMI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "L&M ORIGINAL BIG/48", 406791, "" },
                    { 9L, "green", 54002418L, "PMI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "L&M BLUE/32", 371874, "" },
                    { 13L, "yellow", 54014459L, "PMI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "L&M ORIGINAL XL/31", 382744, "" },
                    { 12L, "yellow", 54014541L, "PMI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "L&M ORIGINAL L/27", 408824, "" },
                    { 11L, "yellow", 54014688L, "PMI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "L&M ORIGINAL M/23", 408808, "" },
                    { 10L, "", 54140431L, "PMI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "L&M ORIGINAL/20", 246506, "" },
                    { 29L, "green", 54141506L, "PMI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "MARLBORO RED/37", 371807, "" },
                    { 8L, "red", 54002388L, "PMI", "Cigarette", 0.0, 0.0, 0.0, 0.0, "L&M BLUE/27", 367540, "" },
                    { 7L, "red", 54002364L, "PMI", "Cigarette", 0.0, 0.0, 0.0, 0.0, "L&M BLUE M/23", 367567, "" },
                    { 6L, "", 54140424L, "PMI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "L&M BLUE/20", 246514, "" },
                    { 5L, "green", 54014510L, "PMI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "CHESTERFIELD RED BIG/47", 408786, "" },
                    { 4L, "green", 54014534L, "PMI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "CHESTERFIELD RED XL/31", 408794, "" },
                    { 3L, "red", 54002401L, "PMI", "Cigarette", 0.0, 0.0, 0.0, 0.0, "CHESTERFIELD RED/34", 370363, "" },
                    { 2L, "red", 54141681L, "PMI", "Cigarette", 0.0, 0.0, 0.0, 0.0, "CHESTERFIELD RED/23", 370339, "" },
                    { 1L, "", 54140660L, "PMI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "CHESTERFIELD RED/20", 250546, "" }
                });

            migrationBuilder.InsertData(
                table: "PMI_Cigarettes",
                columns: new[] { "Id", "Color", "Eancode", "Fabrikant", "Groupe", "Nielsen1", "Nielsen2", "Nielsen3", "Nielsen4", "Product", "Ref", "Size" },
                values: new object[] { 14L, "", 54141643L, "PMI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "L&m Orignal XXL/39", 371920, "" });

            migrationBuilder.InsertData(
                table: "PMI_Cigarettes",
                columns: new[] { "Id", "Color", "Eancode", "Fabrikant", "Groupe", "Nielsen1", "Nielsen2", "Nielsen3", "Nielsen4", "Product", "Ref", "Size" },
                values: new object[] { 30L, "green", 54014503L, "PMI", "Cigarette", 1.0, 1.0, 1.0, 1.0, "MARLBORO RED BIG 48", 416789, "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BAT_Cigarettes");

            migrationBuilder.DropTable(
                name: "BAT_Tabacs");

            migrationBuilder.DropTable(
                name: "ITB_Cigarettes");

            migrationBuilder.DropTable(
                name: "ITB_Tabacs");

            migrationBuilder.DropTable(
                name: "JTI_Cigarettes");

            migrationBuilder.DropTable(
                name: "JTI_Tabacs");

            migrationBuilder.DropTable(
                name: "PMI_Cigarettes");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
