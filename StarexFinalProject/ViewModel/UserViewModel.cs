using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StarexFinal.ViewModels
{
    public class UserViewModel
    {
        [Required]
        [Display(Name= "Ad (ingilis hərflərilə)")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Soyad (ingilis hərflərilə)")]
        public string Surname { get; set; }
        [Required]
        [Display(Name = "Cinsinizi seçin")]
        public string Gender { get; set; }
        [Required]
        [Display(Name = "Doğum tarixi")]
        public DateTime BirthDate { get; set; }
        [Required]
        [Display(Name = "Ünvan")]
        public string Adress { get; set; }
        [Required]
        [Display(Name = "Bağlamaları təhvil almaq istədiyiniz filial")]
        public int WareHousesId { get; set; }
        [Required]
        public string GovIdPrefix { get; set; }
        [Required]
        [Display(Name = "Şəxsiyyət vəsiqəsinin seriya və nömrəsi")]
        public string GovId { get; set; }
        [Required]
        [MaxLength(7)]
        [Display(Name = "FIN Kod")]
        public string FIN { get; set; }
        [Required]
        [Display(Name = "Telefon")]
        public int Phone { get; set; }
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Şifrə")]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Şifrənin təkrarı")]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
