using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HistoricoEscolar.Migrations
{
    public partial class AlterandoTabelaHistórico5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Historicos_Alunos_AlunoId",
                table: "Historicos");

            migrationBuilder.DropForeignKey(
                name: "FK_Historicos_Disciplinas_DisciplinaId",
                table: "Historicos");

            migrationBuilder.AlterColumn<int>(
                name: "DisciplinaId",
                table: "Historicos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AlunoId",
                table: "Historicos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Historicos_Alunos_AlunoId",
                table: "Historicos",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "AlunoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Historicos_Disciplinas_DisciplinaId",
                table: "Historicos",
                column: "DisciplinaId",
                principalTable: "Disciplinas",
                principalColumn: "DisciplinaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Historicos_Alunos_AlunoId",
                table: "Historicos");

            migrationBuilder.DropForeignKey(
                name: "FK_Historicos_Disciplinas_DisciplinaId",
                table: "Historicos");

            migrationBuilder.AlterColumn<int>(
                name: "DisciplinaId",
                table: "Historicos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AlunoId",
                table: "Historicos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Historicos_Alunos_AlunoId",
                table: "Historicos",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "AlunoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Historicos_Disciplinas_DisciplinaId",
                table: "Historicos",
                column: "DisciplinaId",
                principalTable: "Disciplinas",
                principalColumn: "DisciplinaId");
        }
    }
}
