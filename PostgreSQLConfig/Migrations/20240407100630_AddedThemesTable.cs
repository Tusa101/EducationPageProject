using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostgreSQLDb.Migrations
{
    /// <inheritdoc />
    public partial class AddedThemesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: "03652bbf-03e1-41f3-9881-f31bb7d36a82");

            migrationBuilder.AddColumn<string>(
                name: "ThemeId",
                table: "Articles",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Themes",
                columns: table => new
                {
                    ThemeId = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Icon = table.Column<byte[]>(type: "bytea", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.ThemeId);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Themes_ThemeId",
                table: "Articles");

            migrationBuilder.DropTable(
                name: "Themes");

            migrationBuilder.DropIndex(
                name: "IX_Articles_ThemeId",
                table: "Articles");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: "13adf83f-679b-4977-a48f-0fc363b8b75d");

            migrationBuilder.DropColumn(
                name: "ThemeId",
                table: "Articles");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "Annotation", "Name", "Text" },
                values: new object[] { "03652bbf-03e1-41f3-9881-f31bb7d36a82", "This article is made to test the db connection", "Init article", "This article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing." });
        }
    }
}
