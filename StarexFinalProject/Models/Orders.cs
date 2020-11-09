using StarexFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarexFinal.Data
{
    public class Orders
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int Amount { get; set; }
        public string  ProductSize { get; set; }
        public string Color { get; set; }
        public string Comment { get; set; }
        public decimal Price { get; set; }
        public decimal Cargo_Price { get; set; }
        public decimal Total_Price { get; set; }
        public int CountryId { get; set; }
        public Countries Countries { get; set; }
        public AppUsers User { get; set; }
    }
}
