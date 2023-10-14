using HistoricoEscolar.Context;
using HistoricoEscolar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            if (historicos is null)
            {
                return NotFound("Dados inválidos, tente novamente!");
            }
            return historicos;
        }


        // Obter historico por id
        [HttpGet("{id:int}", Name = "ObterHistoricoPorId")]
        public ActionResult<Historico> Get(int id)
        {
            var historico = _context.Historicos.FirstOrDefault(h => h.HistoricoId == id);
            if (historico is null)
            {
                return NotFound("Dados inválidos, tente novamente!");
            }
            return historico;
        }


        // Deletar historico
        [HttpDelete("{id:int}")]
        public ActionResult Post(int id)
        {
            var historico = _context.Historicos.FirstOrDefault(h => h.HistoricoId == id);
            if (historico is null)
            {
                return BadRequest("Dados inválidos, tente novamente!");
            }

            _context.Historicos.Remove(historico);
            _context.SaveChanges();

            return Ok("Dados apagados com sucesso!");

        }


        // Postar historico
        [HttpPost]
        public ActionResult Post(Historico historico)
        {
            if(historico is null)
            {
                return BadRequest("Dados inválidos");
            }

            historico.Media = ((historico.AvalicaoOnline) + (historico.PIM * 2) + (historico.AvaliacaoPresencial * 7)) / 10;

            if(historico.Media >= 6)
            {
                historico.Situacao = "Aprovado";
            }
            else
            {
                historico.Situacao = "Reprovado";
            }

            _context.Historicos.Add(historico);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterHistoricoPorId", new { id = historico.HistoricoId},historico);
        }

        // Alterar historico
        [HttpPut("{id:int}")]
        public ActionResult Put(int id,Historico historico)
        {
            if(id != historico.HistoricoId)
            {
                return BadRequest("Dados inválidos, tente novamente!");
            }

            historico.Media = ((historico.AvalicaoOnline) + (historico.PIM * 2) + (historico.AvaliacaoPresencial * 7)) / 10;

            if (historico.Media >= 6)
            {
                historico.Situacao = "Aprovado";
            }
            else
            {
                historico.Situacao = "Reprovado";
            }

            _context.Entry(historico).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(historico);
        }

    }
}
