using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostgreSQLDb.Migrations
{
    /// <inheritdoc />
    public partial class ChangedThemesEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: "855bb2ba-33b4-4786-86f8-56d622a9289b");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Themes",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "Annotation", "InThemePostionNumber", "Name", "Text", "ThemeId" },
                values: new object[] { "d26eb242-4be0-4694-8959-48ace8a54d4e", "This article is made to test the db connection", 1, "Init article", "This article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.", "1" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "ThemeId",
                keyValue: "2",
                column: "ImagePath",
                value: "/images/Bonds.png");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "ThemeId",
                keyValue: "3",
                column: "ImagePath",
                value: "/images/Crypto.png");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "ThemeId",
                keyValue: "4",
                column: "ImagePath",
                value: "/images/ETF.png");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "ThemeId",
                keyValue: "5",
                column: "ImagePath",
                value: "/images/Goods.png");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "ThemeId",
                keyValue: "6",
                column: "ImagePath",
                value: "/images/Forex.png");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "ThemeId",
                keyValue: "7",
                column: "ImagePath",
                value: "/images/Futures.png");

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "ThemeId", "ImagePath", "Name" },
                values: new object[] { "8", "/images/TechAnalysis.png", "TechAnalysis" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: "d26eb242-4be0-4694-8959-48ace8a54d4e");

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "ThemeId",
                keyValue: "8");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Themes");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "Annotation", "InThemePostionNumber", "Name", "Text", "ThemeId" },
                values: new object[] { "855bb2ba-33b4-4786-86f8-56d622a9289b", "This article is made to test the db connection", 1, "Init article", "This article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.", "1" });
        }
    }
}
