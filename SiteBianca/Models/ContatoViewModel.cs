using System.ComponentModel.DataAnnotations;

namespace SiteBianca.Models
{
    public class ContatoViewModel
    {
        [Required(ErrorMessage = "Por favor, informe seu nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe seu email.")]
        [EmailAddress(ErrorMessage = "Email inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Por favor, escreva uma mensagem.")]
        public string Mensagem { get; set; }
    }
}
