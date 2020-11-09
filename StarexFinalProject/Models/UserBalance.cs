using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarexFinal.Models
{
    public class UserBalance
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public int CurrencyId { get; set; }
        public AppUsers AppUsers { get; set; }
    }
}
