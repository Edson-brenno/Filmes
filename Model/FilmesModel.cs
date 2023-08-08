using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models{
    public class Filme{
        [Required(ErrorMessage = "O titulo do filme não pode ser nulo")]
        [StringLength(500, ErrorMessage = "Titulo tem que ser menor que 500 caracteres")]
        public string titulo {get; set;}

        [Required(ErrorMessage = "O genero não pode ser nulo")]
        public string genero {get; set;}

        public int ano {get; set;}

        public List<AtorElenco> elencos {get; set;}
        public double duracao {get; set;}

    }
}