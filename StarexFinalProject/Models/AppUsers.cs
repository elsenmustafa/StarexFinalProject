using Microsoft.AspNetCore.Identity;
using StarexFinal.Data;
using StarexFinalProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StarexFinal.Models
{
    public class AppUsers:IdentityUser
    {
        [Required]
        public int AppUserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public int WarehouseId { get; set; }
        [Required]
        public string GovIdPrefix { get; set; }
        [Required]
        public string GovId { get; set; }
        [Required]
        public string FIN { get; set; }
        public ICollection<Orders> Orders  { get; set; }
        public ICollection<Declarations> Declarations { get; set; }
        public ICollection<UserBalance> UserBalance { get; set; }
        public  Warehouse Warehouses { get; set; }
    }
}
