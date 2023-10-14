using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HistoricoEscolar.Migrations
{
    public partial class CriacaoDaTabela8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NomeCurso",
                table: "Cursos",
                newName: "NomeDoCurso");

            migrationBuilder.AlterColumn<string>(
                name: "NomeDaDisciplina",
                table: "Disciplinas",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NomeDoCurso",
                table: "Cursos",
                newName: "NomeCurso");

            migrationBuilder.AlterColumn<string>(
                name: "NomeDaDisciplina",
                table: "Disciplinas",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
