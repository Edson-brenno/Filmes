using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models{
    
    public class AtorElenco{

        [Required]
        [StringLength(500, ErrorMessage = "Error - nome muito grande")]
        public string nome { get; set; }

        public string sobrenome  { get; set; }
    }

}