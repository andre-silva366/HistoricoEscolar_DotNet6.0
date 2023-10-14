using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HistoricoEscolar.Migrations
{
    public partial class CriacaoDaTabela6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Histórico_Alunos_AlunoId",
                table: "Histórico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "AlunoId",
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
                name: "NomeDoCurso",
                table: "Cursos",
                newName: "NomeCurso");

            migrationBuilder.RenameColumn(
                name: "Matricula",
                table: "Alunos",
                newName: "MatriculaId");

            migrationBuilder.AlterColumn<int>(
                name: "CursoId",
                table: "Alunos",
                type: "int(2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MatriculaId",
                table: "Alunos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos",
                column: "MatriculaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Histórico_Alunos_AlunoMatriculaId",
                table: "Histórico",
                column: "AlunoMatriculaId",
                principalTable: "Alunos",
                principalColumn: "MatriculaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Histórico_Alunos_AlunoMatriculaId",
                table: "Histórico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos");

            migrationBuilder.RenameColumn(
                name: "AlunoMatriculaId",
                table: "Histórico",
                newName: "AlunoId");

            migrationBuilder.RenameIndex(
                name: "IX_Histórico_AlunoMatriculaId",
                table: "Histórico",
                newName: "IX_Histórico_AlunoId");

            migrationBuilder.RenameColumn(
                name: "NomeCurso",
                table: "Cursos",
                newName: "NomeDoCurso");

            migrationBuilder.RenameColumn(
                name: "MatriculaId",
                table: "Alunos",
                newName: "Matricula");

            migrationBuilder.AlterColumn<int>(
                name: "CursoId",
                table: "Alunos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int(2)");

            migrationBuilder.AlterColumn<int>(
                name: "Matricula",
                table: "Alunos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AlunoId",
                table: "Alunos",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos",
                column: "AlunoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Histórico_Alunos_AlunoId",
                table: "Histórico",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "AlunoId");
        }
    }
}
