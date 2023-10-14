using HistoricoEscolar.Models;
using Microsoft.EntityFrameworkCore;

namespace HistoricoEscolar.Context;

public class AppDbContext : DbContext 
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Disciplina> Disciplinas { get; set; }
    public DbSet<Historico> Historicos { get; set; }
    public DbSet<Curso> Cursos { get; set; }
}
