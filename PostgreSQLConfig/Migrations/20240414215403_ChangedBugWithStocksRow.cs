using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostgreSQLDb.Migrations
{
    /// <inheritdoc />
    public partial class ChangedBugWithStocksRow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: "d26eb242-4be0-4694-8959-48ace8a54d4e");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "Annotation", "InThemePostionNumber", "Name", "Text", "ThemeId" },
                values: new object[] { "2567fdd3-bc16-469f-bb10-88830ba3035d", "This article is made to test the db connection", 1, "Init article", "This article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.", "1" });

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "ThemeId", "ImagePath", "Name" },
                values: new object[] { "1", "/images/Stocks.png", "Stocks" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: "2567fdd3-bc16-469f-bb10-88830ba3035d");

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "ThemeId",
                keyValue: "1");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "Annotation", "InThemePostionNumber", "Name", "Text", "ThemeId" },
                values: new object[] { "d26eb242-4be0-4694-8959-48ace8a54d4e", "This article is made to test the db connection", 1, "Init article", "This article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.", "1" });
        }
    }
}
