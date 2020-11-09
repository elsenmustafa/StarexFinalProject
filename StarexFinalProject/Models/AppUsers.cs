using Microsoft.AspNetCore.Identity;
using StarexFinal.Data;
using StarexFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarexFinal.Models
{
    public class AppUsers:IdentityUser
    {
        public int AppUserId { get; set; }
        public string Name { get; set; }    
        public string Surname { get; set; }   
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Adress { get; set; }
        public string WareHousesId { get; set; }
        public string GovIdPrefix { get; set; }
        public string GovId { get; set; }
        public string FIN { get; set; }
        public ICollection<Orders> Orders  { get; set; }
        public ICollection<Declarations> Declarations { get; set; }
        public ICollection<UserBalance> UserBalance { get; set; }
        public  Warehouse Warehouses { get; set; }
    }
}
