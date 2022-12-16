using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTO
{
    public class UpdateFilmeDto
    {
        [Required(ErrorMessage = "Campo Título é obrigatório.")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Campo diretor é obrigatório.")]
        public string Diretor { get; set; }
        [StringLength(40, ErrorMessage = "O campo Genero deve ter até 40 caracteres.")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A duração deve ser estar 1min e 10h.")]
        public int Duracao { get; set; }
    }
}
