using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models{
    public class Filme{
        [Required(ErrorMessage = "O titulo do filme não pode ser nulo")]
        [StringLength(500, ErrorMessage = "Titulo tem que ser menor que 500 caracteres")]
        public string titulo {get; set;}

        [Required(ErrorMessage = "O genero não pode ser nulo")]
        public string genero {get; set;}

        [Required(ErrorMessage = "O ano não pode ser nulo")]
        public int ano {get; set;}

        public List<AtorElenco> elencos {get; set;}

        [Required(ErrorMessage = "A duração do filme não pode ser nula")]
        public double duracao {get; set;}

        override public string ToString(){
            return $"{titulo} \n {genero} \n {ano} \n {elencos.ToString()} \n {duracao}";
        }
    }
}