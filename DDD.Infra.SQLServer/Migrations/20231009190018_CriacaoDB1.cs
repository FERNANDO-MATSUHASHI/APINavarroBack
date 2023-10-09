using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DDD.Infra.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoDB1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjetosTI_Programador_ProgramadorId",
                table: "ProjetosTI");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Programador",
                table: "Programador");

            migrationBuilder.RenameTable(
                name: "Programador",
                newName: "ProgramadorTI");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProgramadorTI",
                table: "ProgramadorTI",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjetosTI_ProgramadorTI_ProgramadorId",
                table: "ProjetosTI",
                column: "ProgramadorId",
                principalTable: "ProgramadorTI",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjetosTI_ProgramadorTI_ProgramadorId",
                table: "ProjetosTI");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProgramadorTI",
                table: "ProgramadorTI");

            migrationBuilder.RenameTable(
                name: "ProgramadorTI",
                newName: "Programador");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Programador",
                table: "Programador",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjetosTI_Programador_ProgramadorId",
                table: "ProjetosTI",
                column: "ProgramadorId",
                principalTable: "Programador",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
