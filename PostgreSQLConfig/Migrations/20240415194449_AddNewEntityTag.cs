using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostgreSQLDb.Migrations
{
    /// <inheritdoc />
    public partial class AddNewEntityTag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: "2567fdd3-bc16-469f-bb10-88830ba3035d");

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    TagId = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.TagId);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "Annotation", "InThemePostionNumber", "Name", "Text", "ThemeId" },
                values: new object[] { "2e0d14ed-052a-4b4d-bf5b-014647277a3d", "This article is made to test the db connection", 1, "Init article", "This article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.", "1" });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "TagId", "Value" },
                values: new object[] { "086aa62e-2d48-415d-bf82-1d674a95d194", "акции" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: "2e0d14ed-052a-4b4d-bf5b-014647277a3d");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "Annotation", "InThemePostionNumber", "Name", "Text", "ThemeId" },
                values: new object[] { "2567fdd3-bc16-469f-bb10-88830ba3035d", "This article is made to test the db connection", 1, "Init article", "This article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.", "1" });
        }
    }
}
