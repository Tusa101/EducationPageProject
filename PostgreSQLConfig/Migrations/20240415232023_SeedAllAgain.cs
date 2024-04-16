using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PostgreSQLDb.Migrations
{
    /// <inheritdoc />
    public partial class SeedAllAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    ArticleId = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    InThemePostionNumber = table.Column<int>(type: "integer", nullable: false),
                    ThemeId = table.Column<string>(type: "text", nullable: false),
                    Annotation = table.Column<string>(type: "text", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.ArticleId);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "Themes",
                columns: table => new
                {
                    ThemeId = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ImagePath = table.Column<string>(type: "text", nullable: false),
                    TagsIds = table.Column<List<string>>(type: "text[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.ThemeId);
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Value" },
                values: new object[,]
                {
                    { "29f5cd84-6506-4f5c-b436-3acb8235f21f", "депозитарии" },
                    { "7566fcc3-7682-47a5-b006-cff520ceacb7", "облигации" },
                    { "8b202bfb-d2a8-4a20-9ac2-eb004f35f09c", "ETF" },
                    { "a9155ab2-ba76-486a-9779-a90a5b6f6ab4", "ТехАнализ" },
                    { "c4e86988-5252-432d-97e4-84709e91b1e9", "акции" },
                    { "dd44442e-a4e2-4cab-893f-8923a6f2764b", "биржа" },
                    { "fd2437cb-62ec-42c4-82f9-1866c30527b6", "фонды" }
                });

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "ThemeId", "ImagePath", "Name", "TagsIds" },
                values: new object[,]
                {
                    { "1", "/images/Stocks.png", "Stocks", new List<string> { "c4e86988-5252-432d-97e4-84709e91b1e9", "dd44442e-a4e2-4cab-893f-8923a6f2764b", "29f5cd84-6506-4f5c-b436-3acb8235f21f" } },
                    { "2", "/images/Bonds.png", "Bonds", new List<string> { "c4e86988-5252-432d-97e4-84709e91b1e9", "7566fcc3-7682-47a5-b006-cff520ceacb7" } },
                    { "3", "/images/Crypto.png", "Crypto", new List<string> { "c4e86988-5252-432d-97e4-84709e91b1e9" } },
                    { "4", "/images/ETF.png", "ETF", new List<string> { "8b202bfb-d2a8-4a20-9ac2-eb004f35f09c", "fd2437cb-62ec-42c4-82f9-1866c30527b6" } },
                    { "5", "/images/Goods.png", "Goods", new List<string> { "c4e86988-5252-432d-97e4-84709e91b1e9" } },
                    { "6", "/images/Forex.png", "Forex", new List<string> { "c4e86988-5252-432d-97e4-84709e91b1e9" } },
                    { "7", "/images/Futures.png", "Futures", new List<string> { "c4e86988-5252-432d-97e4-84709e91b1e9" } },
                    { "8", "/images/TechAnalysis.png", "TechAnalysis", new List<string> { "a9155ab2-ba76-486a-9779-a90a5b6f6ab4" } }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Themes");
        }
    }
}
