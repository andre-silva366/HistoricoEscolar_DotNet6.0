using HistoricoEscolar.Context;
using HistoricoEscolar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HistoricoEscolar.Controllers;

[Route("[controller]")]
[ApiController]
public class AlunoController : ControllerBase
{
    private readonly AppDbContext _context;

    public AlunoController(AppDbContext context)
    {
        _context = context;
    }

    // Retornar todos os alunos
    [HttpGet(Name = "Obter alunos")]
    public ActionResult<IEnumerable<Aluno>> Get()
    {
        var alunos = _context.Alunos.ToList();

        if (alunos is null)
        {
            return NotFound("Não existem alunos cadastrados.");
        }

        return alunos;
    }

    // Obter aluno por id
    [HttpGet("{id:int}",Name ="ObterPorId")]
    public ActionResult<Aluno> Get(int id)
    {
        var aluno = _context.Alunos.FirstOrDefault(a => a.AlunoId == id);
        if (aluno is null)
        {
            return NotFound("Aluno não encontrado!");
        }
        return aluno;
    }

    // Incluir aluno
    [HttpPost(Name ="Incluir Aluno")]
    public ActionResult Post(Aluno aluno)
    {
        if(aluno is null)
        {
            return BadRequest("Dados inválidos, tente novamente.");
        }
        _context.Alunos.Add(aluno);
        _context.SaveChanges();

        return new CreatedAtRouteResult("ObterPorId", new { id = aluno.AlunoId},aluno);
    }

    // Alterar dados do Aluno
    [HttpPut("{id:int}")]
    public ActionResult Put(int id,Aluno aluno) 
    {
        if(id != aluno.AlunoId)
        {
            return BadRequest("Aluno não encontrado!");
        }   
        _context.Entry(aluno).State = EntityState.Modified;
        _context.SaveChanges();

        return Ok(aluno);
    }

    // Deletar aluno
    [HttpDelete("{id:int}")]
    public ActionResult Delete(int id)
    {
        var aluno = _context.Alunos.FirstOrDefault(a => a.AlunoId == id);

        if(aluno is null)
        {
            return NotFound("Aluno não encontrado!");
        }

        _context.Alunos.Remove(aluno);
        _context.SaveChanges();

        return Ok("Aluno excluido com sucesso!");
    }
}
