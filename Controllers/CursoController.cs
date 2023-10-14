using HistoricoEscolar.Context;
using HistoricoEscolar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HistoricoEscolar.Controllers;

[Route("[controller]")]
[ApiController]
public class CursoController : ControllerBase
{
    private readonly AppDbContext _context;

    public CursoController(AppDbContext context)
    {
        _context = context;
    }

    //Obter todos os cursos
    [HttpGet]
    public ActionResult<IEnumerable<Curso>> Get()
    {
        var cursos = _context.Cursos.ToList();
        if (cursos is null)
        {
            return BadRequest();
        }
        return Ok(cursos);
    }

    //Obter curso por id
    [HttpGet("{id:int}", Name = "ObterCursoPorId")]
    public ActionResult<Curso> Get(int id)
    {
        var curso = _context.Cursos.FirstOrDefault(c => c.CursoId == id);
        if (curso is null)
        {
            return NotFound("Curso não encontrado!");
        }
        return curso;
    }

    // Incluir um curso
    [HttpPost]
    public ActionResult Post(Curso curso)
    {
        if(curso is null)
        {
            return BadRequest("Dados inválidos, tente novamente!");
        }
        _context.Cursos.Add(curso);
        _context.SaveChanges();
        return new CreatedAtRouteResult("ObterCursoPorId",new {id = curso.CursoId},curso);
    }

    // Alterar curso
    [HttpPut("{id:int}")]
    public ActionResult Put(int id, Curso curso)
    {
        if(id != curso.CursoId)
        {
            return BadRequest("Dados inválidos, tente novamente!");
        }
        _context.Entry(curso).State = EntityState.Modified;
        _context.SaveChanges();

        return Ok(curso);
    }

    //Deletar curso
    [HttpDelete("{id:int}")]
    public ActionResult Delete(int id)
    {
        var curso = _context.Cursos.FirstOrDefault(c => c.CursoId==id);
        if(curso is null)
        {
            return NotFound("Curso não encontrado!");
        }
        _context.Cursos.Remove(curso);
        _context.SaveChanges();
        return Ok(curso);
    }

    
}
