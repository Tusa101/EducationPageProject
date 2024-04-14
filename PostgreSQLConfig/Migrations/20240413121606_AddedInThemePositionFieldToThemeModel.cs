using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostgreSQLDb.Migrations
{
    /// <inheritdoc />
    public partial class AddedInThemePositionFieldToThemeModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: "a8b5a9da-d014-48ca-a138-cd4ee4d52795");

            migrationBuilder.AddColumn<int>(
                name: "InThemePostionNumber",
                table: "Articles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "Annotation", "InThemePostionNumber", "Name", "Text", "ThemeId" },
                values: new object[] { "855bb2ba-33b4-4786-86f8-56d622a9289b", "This article is made to test the db connection", 1, "Init article", "This article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.", "1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: "855bb2ba-33b4-4786-86f8-56d622a9289b");

            migrationBuilder.DropColumn(
                name: "InThemePostionNumber",
                table: "Articles");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "Annotation", "Name", "Text", "ThemeId" },
                values: new object[] { "a8b5a9da-d014-48ca-a138-cd4ee4d52795", "This article is made to test the db connection", "Init article", "This article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.", "1" });
        }
    }
}
