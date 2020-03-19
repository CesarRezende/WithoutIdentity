using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WithoutIdentity.Models.AccountViewModels
{
    public class LoginViewModel
    {

        [Required]
        [EmailAddress]
        //[Display(Name = "E-mail")]
        public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        //[Display(Name = "Senha")]
        //[StringLength(100, ErrorMessage = "O campo {0} de ter no minimo {2} e no máximo {1} caracteres", MinimumLength = 8)]
        public string Password { get; set; }

        [Display(Name = "Lembrar login")]
        public bool Rememberme { get; set; }
    }
}
