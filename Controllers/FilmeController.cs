using Microsoft.AspNetCore.Mvc;
using FilmesApi.Models;

namespace FilmesApi.Controllers{

    [ApiController]

    [Route("[controller]")]
    public class FilmeController : ControllerBase {
        
        private static List<Filme> filmes = new List<Filme>();
        // Adiciona filme
        [HttpPost]
        public IActionResult AdicionaFilme([FromBody] Filme filmeNovo){
            filmes.Add(filmeNovo);
            return CreatedAtAction(nameof(GetFilmeId), new {id = filmeNovo.id},filmeNovo);
        }

        //Obter os filmes
        [HttpGet]
        public IEnumerable<Filme> GetFilmes([FromQuery] int pule = 0, [FromQuery] int pegue = 3){
            return filmes.Skip(pule).Take(pegue);
        }

        //Obter um filme:
        [HttpGet("id/{id}")]
        public IActionResult GetFilmeId(int id){
            Filme filme= filmes.FirstOrDefault(x => x.id == id);
            if (filme == null){ return NotFound();};
            return Ok(filme);
        }

        [HttpGet("nome/{nome}")]

        public List<Filme>? GetFilmeByName(string nome){
            return filmes.FindAll(x => x.titulo.StartsWith(nome.ToUpper()));
        }
    }
}