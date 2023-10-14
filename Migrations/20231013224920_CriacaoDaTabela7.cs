using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HistoricoEscolar.Migrations
{
    public partial class CriacaoDaTabela7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Histórico_Alunos_AlunoMatriculaId",
                table: "Histórico");

            migrationBuilder.RenameColumn(
                name: "AlunoMatriculaId",
                table: "Histórico",
                newName: "AlunoId");

            migrationBuilder.RenameIndex(
                name: "IX_Histórico_AlunoMatriculaId",
                table: "Histórico",
                newName: "IX_Histórico_AlunoId");

            migrationBuilder.RenameColumn(
                name: "MatriculaId",
                table: "Alunos",
                newName: "AlunoId");

            migrationBuilder.AddColumn<int>(
                name: "Matricula",
                table: "Alunos",
                type: "int(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Histórico_Alunos_AlunoId",
                table: "Histórico",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "AlunoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Histórico_Alunos_AlunoId",
                table: "Histórico");

            migrationBuilder.DropColumn(
                name: "Matricula",
                table: "Alunos");

            migrationBuilder.RenameColumn(
                name: "AlunoId",
                table: "Histórico",
                newName: "AlunoMatriculaId");

            migrationBuilder.RenameIndex(
                name: "IX_Histórico_AlunoId",
                table: "Histórico",
                newName: "IX_Histórico_AlunoMatriculaId");

            migrationBuilder.RenameColumn(
                name: "AlunoId",
                table: "Alunos",
                newName: "MatriculaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Histórico_Alunos_AlunoMatriculaId",
                table: "Histórico",
                column: "AlunoMatriculaId",
                principalTable: "Alunos",
                principalColumn: "MatriculaId");
        }
    }
}
