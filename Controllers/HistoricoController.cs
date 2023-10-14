using HistoricoEscolar.Context;
using HistoricoEscolar.Models;
using Microsoft.AspNetCore.Mvc;

namespace HistoricoEscolar.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HistoricoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HistoricoController(AppDbContext context)
        {
            _context = context;
        }

        // Obter todos os historicos
        [HttpGet]
        public ActionResult<IEnumerable<Historico>> Get()
        {
            var historicos = _context.Historicos.ToList();
            if(historicos is null)
            {
                return NotFound("Dados inválidos, tente novamente!");
            }
            return historicos;
        }

        [HttpGet("{id:int}",Name ="ObterHistoricoPorId")]
        public ActionResult<Historico> Get(int id)
        {
            var historico = _context.Historicos.FirstOrDefault(h => h.HistoricoId == id);
            if(historico is null)
            {
                return NotFound("Dados inválidos, tente novamente!");
            }
            return historico;
        }

        [HttpPost]
        public ActionResult Post(Historico historico)
        {
            if(historico is null)
            {
                return BadRequest("Dados inválidos, tente novamente!");
            }
            
            _context.Historicos.Add(historico);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterHistoricoPorId", new { id = historico.HistoricoId }, historico);

        }
    }
}
