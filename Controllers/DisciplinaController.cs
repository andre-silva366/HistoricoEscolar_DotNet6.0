using HistoricoEscolar.Context;
using HistoricoEscolar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HistoricoEscolar.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DisciplinaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DisciplinaController(AppDbContext context)
        {
            _context = context;
        }

        // Obter todas as disciplinas
        [HttpGet]
        public ActionResult<IEnumerable<Disciplina>> Get()
        {
            var disciplinas = _context.Disciplinas.ToList();
            if(disciplinas is null || disciplinas.Count == 0)
            {
                return NotFound("Não há disciplinas cadastradas");
            }
            return disciplinas;
        }

        // Obter disciplina por id
        [HttpGet("{id:int}",Name ="ObterDisciplinaPorId")]
        public ActionResult<Disciplina> Get(int id)
        {
            var disciplina = _context.Disciplinas.FirstOrDefault(d => d.DisciplinaId == id);
            if(disciplina is null)
            {
                return NotFound("Dados inválidos, tente novamente!");
            }
            return disciplina;
        }

        // Adicionar disciplina
        [HttpPost]
        public ActionResult Post(Disciplina disciplina)
        {
            if(disciplina is null)
            {
                return BadRequest("Dados inválidos, tente novamente!");
            }
            _context.Disciplinas.Add(disciplina);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterDisciplinaPorId", new { id = disciplina.DisciplinaId }, disciplina);
        }

        // Alterar disciplina
        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Disciplina disciplina)
        {
            if(id != disciplina.DisciplinaId)
            {
                return BadRequest("Dados inválidos, tente novamente!");
            }
            _context.Entry(disciplina).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(disciplina);
        }

        // Deletar disciplina
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var disciplina = _context.Disciplinas.FirstOrDefault(d => d.DisciplinaId == id);

            if(disciplina is null)
            {
                return NotFound("Dados inválidos, tente novamente!");
            }
            _context.Disciplinas.Remove(disciplina);
            _context.SaveChanges();
            return Ok(disciplina);
        }
    }
}
