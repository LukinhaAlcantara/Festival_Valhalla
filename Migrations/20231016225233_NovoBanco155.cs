using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Festival_Valhalla.Migrations
{
    /// <inheritdoc />
    public partial class NovoBanco155 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ComentarioId",
                table: "Albuns",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ComentarioModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Comentario = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComentarioModel", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Albuns_ComentarioId",
                table: "Albuns",
                column: "ComentarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Albuns_ComentarioModel_ComentarioId",
                table: "Albuns",
                column: "ComentarioId",
                principalTable: "ComentarioModel",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albuns_ComentarioModel_ComentarioId",
                table: "Albuns");

            migrationBuilder.DropTable(
                name: "ComentarioModel");

            migrationBuilder.DropIndex(
                name: "IX_Albuns_ComentarioId",
                table: "Albuns");

            migrationBuilder.DropColumn(
                name: "ComentarioId",
                table: "Albuns");
        }
    }
}
