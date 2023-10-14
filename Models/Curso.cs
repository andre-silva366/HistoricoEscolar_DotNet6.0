using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HistoricoEscolar.Models;

[Table("Cursos")]
public class Curso
{
    [Key]
    public int CursoId { get; set; }

    [Required]
    [StringLength(100)]
    public string? NomeDoCurso { get; set;}

}
