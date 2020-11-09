using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarexFinal.Data
{
    public class Countries
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Orders> Orders { get; set; }
        public ICollection<Declarations> Declarations { get; set; }
    }
}