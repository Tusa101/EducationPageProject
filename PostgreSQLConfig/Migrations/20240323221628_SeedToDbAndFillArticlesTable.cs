using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostgreSQLDb.Migrations
{
    /// <inheritdoc />
    public partial class SeedToDbAndFillArticlesTable : Migration
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
                    Annotation = table.Column<string>(type: "text", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.ArticleId);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "Annotation", "Name", "Text" },
                values: new object[] { "03652bbf-03e1-41f3-9881-f31bb7d36a82", "This article is made to test the db connection", "Init article", "This article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");
        }
    }
}
