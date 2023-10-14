using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HistoricoEscolar.Migrations
{
    public partial class CriacaoDaTabela3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Curso_CursoId1",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Historicos_Alunos_AlunoId",
                table: "Historicos");

            migrationBuilder.DropForeignKey(
                name: "FK_Historicos_Disciplinas_DisciplinaId",
                table: "Historicos");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_CursoId1",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "CursoId1",
                table: "Alunos");

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

            migrationBuilder.AlterColumn<int>(
                name: "CursoId",
                table: "Alunos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_CursoId",
                table: "Alunos",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Alunos_CursoId",
                table: "Alunos");

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

            migrationBuilder.AlterColumn<string>(
                name: "CursoId",
                table: "Alunos",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CursoId1",
                table: "Alunos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_CursoId1",
                table: "Alunos",
                column: "CursoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Curso_CursoId1",
                table: "Alunos",
                column: "CursoId1",
                principalTable: "Curso",
                principalColumn: "CursoId",
                onDelete: ReferentialAction.Cascade);

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
    }
}
