using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Festival_Valhalla.Migrations
{
    /// <inheritdoc />
    public partial class NovoBanco885 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albuns_ComentarioModel_ComentarioId",
                table: "Albuns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComentarioModel",
                table: "ComentarioModel");

            migrationBuilder.RenameTable(
                name: "ComentarioModel",
                newName: "Comentarios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comentarios",
                table: "Comentarios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Albuns_Comentarios_ComentarioId",
                table: "Albuns",
                column: "ComentarioId",
                principalTable: "Comentarios",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albuns_Comentarios_ComentarioId",
                table: "Albuns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comentarios",
                table: "Comentarios");

            migrationBuilder.RenameTable(
                name: "Comentarios",
                newName: "ComentarioModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComentarioModel",
                table: "ComentarioModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Albuns_ComentarioModel_ComentarioId",
                table: "Albuns",
                column: "ComentarioId",
                principalTable: "ComentarioModel",
                principalColumn: "Id");
        }
    }
}
