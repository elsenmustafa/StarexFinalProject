using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StarexFinalProject.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name ="E-POCT UNVANI")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)] 
        [Display(Name ="Sifre")]
        public string Password { get; set; }
    }
}
