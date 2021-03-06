using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo título é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretos é obrigatório")]
        public string Diretor { get; set; }
        [StringLength(100, ErrorMessage = "O gênero não pode exceder 100 caracteres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A duração deve ter no mínimo 1 e no máximo 600 minutos")]
        public int Duracao { get; set; }
    }
}
