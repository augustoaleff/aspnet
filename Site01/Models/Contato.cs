using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Site01.Models
{
    public class Contato
    {
           
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo nome deve conter o máximo de 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo email é obrigatório")]
        [MaxLength(70, ErrorMessage = "O campo email deve conter o máximo de 70 caracteres")]
        [EmailAddress(ErrorMessage = "O campo email é inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo assunto é obrigatório")]
        [MaxLength(70, ErrorMessage = "O campo assunto deve conter o máximo de 70 caracteres")]
        public string Assunto { get; set; }

        [Required(ErrorMessage = "O campo mensagem é obrigatório")]
        [MaxLength(2000, ErrorMessage = "O campo mensagem deve conter o máximo de 70 caracteres")]
        public string Mensagem { get; set; }

    }
}
