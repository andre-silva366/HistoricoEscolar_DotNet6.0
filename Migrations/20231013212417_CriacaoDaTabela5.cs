using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HistoricoEscolar.Migrations
{
    public partial class CriacaoDaTabela5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Curso_CursoId",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Historicos_Alunos_AlunoId",
                table: "Historicos");

            migrationBuilder.DropForeignKey(
                name: "FK_Historicos_Disciplinas_DisciplinaId",
                table: "Historicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Historicos",
                table: "Historicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Curso",
                table: "Curso");

            migrationBuilder.RenameTable(
                name: "Historicos",
                newName: "Histórico");

            migrationBuilder.RenameTable(
                name: "Curso",
                newName: "Cursos");

            migrationBuilder.RenameIndex(
                name: "IX_Historicos_DisciplinaId",
                table: "Histórico",
                newName: "IX_Histórico_DisciplinaId");

            migrationBuilder.RenameIndex(
                name: "IX_Historicos_AlunoId",
                table: "Histórico",
                newName: "IX_Histórico_AlunoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Histórico",
                table: "Histórico",
                column: "HistoricoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cursos",
                table: "Cursos",
                column: "CursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Cursos_CursoId",
                table: "Alunos",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "CursoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Histórico_Alunos_AlunoId",
                table: "Histórico",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "AlunoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Histórico_Disciplinas_DisciplinaId",
                table: "Histórico",
                column: "DisciplinaId",
                principalTable: "Disciplinas",
                principalColumn: "DisciplinaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Cursos_CursoId",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Histórico_Alunos_AlunoId",
                table: "Histórico");

            migrationBuilder.DropForeignKey(
                name: "FK_Histórico_Disciplinas_DisciplinaId",
                table: "Histórico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Histórico",
                table: "Histórico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cursos",
                table: "Cursos");

            migrationBuilder.RenameTable(
                name: "Histórico",
                newName: "Historicos");

            migrationBuilder.RenameTable(
                name: "Cursos",
                newName: "Curso");

            migrationBuilder.RenameIndex(
                name: "IX_Histórico_DisciplinaId",
                table: "Historicos",
                newName: "IX_Historicos_DisciplinaId");

            migrationBuilder.RenameIndex(
                name: "IX_Histórico_AlunoId",
                table: "Historicos",
                newName: "IX_Historicos_AlunoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Historicos",
                table: "Historicos",
                column: "HistoricoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Curso",
                table: "Curso",
                column: "CursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Curso_CursoId",
                table: "Alunos",
                column: "CursoId",
                principalTable: "Curso",
                principalColumn: "CursoId",
                onDelete: ReferentialAction.Cascade);

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
