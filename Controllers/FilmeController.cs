using Microsoft.AspNetCore.Mvc;
using FilmesApi.Models;

namespace FilmesApi.Controllers{

    [ApiController]

    [Route("[controller]")]
    public class FilmeController : ControllerBase {
        
        private static List<Filme> filmes = new List<Filme>();
        // Adiciona filme
        [HttpPost]
        public void AdicionaFilme([FromBody] Filme filmeNovo){
            filmes.Add(filmeNovo);
            System.Console.WriteLine("Escreveu");
        }

        //Obter os filmes
        [HttpGet]
        public string GetFilmes(){
            return "Seila";
        }
    }
}