using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PostgreSQLDb.Migrations
{
    /// <inheritdoc />
    public partial class AddDataToThemes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Themes_ThemeId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_ThemeId",
                table: "Articles");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: "13adf83f-679b-4977-a48f-0fc363b8b75d");

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Themes");

            migrationBuilder.AlterColumn<string>(
                name: "ThemeId",
                table: "Articles",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "Annotation", "Name", "Text", "ThemeId" },
                values: new object[] { "a8b5a9da-d014-48ca-a138-cd4ee4d52795", "This article is made to test the db connection", "Init article", "This article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.", "1" });

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "ThemeId", "Name" },
                values: new object[,]
                {
                    { "2", "Bonds" },
                    { "3", "Crypto" },
                    { "4", "ETF" },
                    { "5", "Goods" },
                    { "6", "Forex" },
                    { "7", "Futures" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: "a8b5a9da-d014-48ca-a138-cd4ee4d52795");

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "ThemeId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "ThemeId",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "ThemeId",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "ThemeId",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "ThemeId",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "ThemeId",
                keyValue: "7");

            migrationBuilder.AddColumn<byte[]>(
                name: "Icon",
                table: "Themes",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AlterColumn<string>(
                name: "ThemeId",
                table: "Articles",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "Annotation", "Name", "Text", "ThemeId" },
                values: new object[] { "13adf83f-679b-4977-a48f-0fc363b8b75d", "This article is made to test the db connection", "Init article", "This article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.", null });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ThemeId",
                table: "Articles",
                column: "ThemeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Themes_ThemeId",
                table: "Articles",
                column: "ThemeId",
                principalTable: "Themes",
                principalColumn: "ThemeId");
        }
    }
}
