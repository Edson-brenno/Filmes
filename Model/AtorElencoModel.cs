using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models{
    
    public class AtorElenco{
        public string nome { get; set; }

        public string sobrenome  { get; set; }

        override public  string ToString(){
            return $"{nome} {sobrenome};";
        }
    }

}