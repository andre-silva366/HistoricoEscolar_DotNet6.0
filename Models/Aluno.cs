using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HistoricoEscolar.Models;

[Table("Alunos")]
public class Aluno
{
    [Key]
    [Required]
    public int AlunoId { get; set; }

    [Required]
    [Column(TypeName ="int(10)")]
    public int Matricula { get;set; }

    [Required]
    [Column(TypeName ="int(2)")]
    public int CursoId { get; set; }

    [Required]
    [StringLength(50)]
    public string? Nome { get; set; }

    [Required]
    [StringLength(50)]
    public string? Polo { get; set; }

    [JsonIgnore]
    public Curso? Curso { get; set; }
}
