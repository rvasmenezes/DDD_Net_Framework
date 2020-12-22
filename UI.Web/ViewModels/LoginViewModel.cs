using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UI.Web.ViewModels
{
    public class LoginViewModel
    {

        [Required]
        [MaxLength(30, ErrorMessage = "Máximo permitido para o Email são 30 caracteres.")]
        [Display(Name = "E-mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Display(Name = "Esqueci minha senha.")]
        public bool RememberMe { get; set; }
    }
}