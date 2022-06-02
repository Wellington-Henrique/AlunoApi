using System.ComponentModel.DataAnnotations;

namespace AlunoApi.ViewModel
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Emaill é obrigatório")]
        [EmailAddress(ErrorMessage = "Formato de email inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "A senha é obrigatória")]
        [StringLength(20, ErrorMessage = "A {0} deve ter no mínimo {2} e no máximo "
            + "{1} caracteres.", MinimumLength = 1)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
