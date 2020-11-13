using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarexFinal.Data
{
    public class Declarations
    {
        public int Id { get; set; }
        public string Shop { get; set; }
        public int Declaration_Amount { get; set; }
        public decimal Price { get; set; }
        public string File { get; set; }
        public int CargoNumber { get; set; }
        public int OrderNumber { get; set; }
        public string Comment { get; set; }
        public int ProductCategoryId { get; set; }
        public int CountryId { get; set; }
        public FormCategory Category { get; set; }
        public Countries Countries { get; set; }
    }
}
