using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models{
    public class Filme{
        
        public static int numberid = 0; 
        public int id {get; private set;}

        [Required(ErrorMessage = "O titulo do filme não pode ser nulo")]
        [StringLength(500, ErrorMessage = "Titulo tem que ser menor que 500 caracteres")]
        private string _titulo;
        public string titulo {
            get { return _titulo; }
            set { _titulo = value.ToUpper(); }
        }

        [Required(ErrorMessage = "O genero não pode ser nulo")]
        private string _genero;
        public string genero {
            get {return _genero; }
            set { _genero = value.ToUpper();}
        }

        [Required(ErrorMessage = "O ano não pode ser nulo")]
        [Range(1900,2023, ErrorMessage = "O ano do filme deve estar entre 1900 à 2023")]
        public int ano {get; set;}

        public List<AtorElenco> elencos {get; set;}

        [Required(ErrorMessage = "A duração do filme não pode ser nula")]
        public double duracao {get; set;}

        override public string ToString(){
            return $"{titulo} \n {genero} \n {ano} \n {duracao}";
        }

        public Filme(){
            this.id = numberid++;
        }
    }
}