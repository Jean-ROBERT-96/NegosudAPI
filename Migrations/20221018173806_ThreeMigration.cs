using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NegosudAPI.Migrations
{
    public partial class ThreeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_Family_id_family",
                table: "Article");

            migrationBuilder.DropIndex(
                name: "IX_Article_id_family",
                table: "Article");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Article_id_family",
                table: "Article",
                column: "id_family");

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Family_id_family",
                table: "Article",
                column: "id_family",
                principalTable: "Family",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
