using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Models
{
    public class Usuario
    {
        [Required(ErrorMessage ="O Email é obrigatório!")]
        [EmailAddress(ErrorMessage ="O Email inserido não é válido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A Senha é obrigatória!")]
        public string Senha { get; set; }
    }
}
