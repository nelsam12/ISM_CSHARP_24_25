using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionDette.Migrations
{
    /// <inheritdoc />
    public partial class ReloadBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ArticleDettes",
                table: "ArticleDettes");

            migrationBuilder.DropIndex(
                name: "IX_ArticleDettes_ArticleId",
                table: "ArticleDettes");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ArticleDettes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArticleDettes",
                table: "ArticleDettes",
                columns: new[] { "ArticleId", "DetteId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ArticleDettes",
                table: "ArticleDettes");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ArticleDettes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArticleDettes",
                table: "ArticleDettes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleDettes_ArticleId",
                table: "ArticleDettes",
                column: "ArticleId");
        }
    }
}
