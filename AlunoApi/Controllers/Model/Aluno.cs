using System.ComponentModel.DataAnnotations;

namespace AlunoApi.Controllers.Model
{
    public class Aluno
    {
        //[Key] - Define uma chave primaria
        public int Id { get; set; }
        [Required]
        [StringLength(80, ErrorMessage ="")]
        public string Nome { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(100, ErrorMessage = "")]
        public string Email { get; set; }
        [Required]
        public int Idade { get; set; }
    }
}
