using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HistoricoEscolar.Migrations
{
    public partial class Recriandotabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.CreateTable(
                name: "Historicos",
                columns: table => new
                {
                    HistoricoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Periodo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AvalicaoOnline = table.Column<decimal>(type: "decimal(2,2)", nullable: false),
                    AvaliacaoPresencial = table.Column<decimal>(type: "decimal(2,2)", nullable: false),
                    PIM = table.Column<decimal>(type: "decimal(2,2)", nullable: false),
                    Media = table.Column<decimal>(type: "decimal(2,2)", nullable: false),
                    Situacao = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AlunoId = table.Column<int>(type: "int", nullable: true),
                    DisciplinaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historicos", x => x.HistoricoId);
                    table.ForeignKey(
                        name: "FK_Historicos_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "AlunoId");
                    table.ForeignKey(
                        name: "FK_Historicos_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "DisciplinaId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_AlunoId",
                table: "Historicos",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_DisciplinaId",
                table: "Historicos",
                column: "DisciplinaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Historicos");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Disciplinas");

            migrationBuilder.DropTable(
                name: "Cursos");
        }
    }
}
