using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HistoricoEscolar.Models;

[Table("Historicos")]
public class Historico
{
    [Key]
    public int HistoricoId { get; set; }

    [Required]
    [StringLength(10)]
    public string? Periodo { get; set; }

    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public double AvalicaoOnline { get; set; }

    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public double AvaliacaoPresencial { get; set; }

    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public double PIM { get; set; }

    public double Media { get; set; }

    [StringLength(10)]
    public string? Situacao { get; set; }

    [Required]
    public int AlunoId { get; set; }

    [Required]
    public int DisciplinaId {get; set; }

    [JsonIgnore]
    public Aluno? Aluno { get; set; }
    [JsonIgnore]
    public Disciplina? Disciplina { get; set;}
    
}
