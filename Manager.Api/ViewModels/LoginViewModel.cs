using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Manager.Api.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "O login não pode ser vazio.")]
        public string Login { get; set; }


        [Required(ErrorMessage = "O login não pode ser vazio.")]
        public string Password { get; set; }


    }
}
