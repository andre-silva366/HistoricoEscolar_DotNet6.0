using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HistoricoEscolar.Models;

[Table("Disciplinas")]
public class Disciplina
{
    [Key]
    public int DisciplinaId { get; set; }

    [Required]
    [StringLength(100)]
    public string? NomeDaDisciplina { get; set; }

}
