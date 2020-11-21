using StarexFinal.Models;
using StarexFinalProject.Models;
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
        public int CountryId { get; set; }
        public int TrackingCode { get; set; }
        public int  Quantity { get; set; }
        public string  ProductSize { get; set; }
        public string Color { get; set; }
        public string Comment { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal Cargo_Price { get; set; }
        public decimal Total_Price { get; set; }
        public DateTime CreatTime { get; set; }
        public int StatusId { get; set; }
        public string UserId { get; set; }
        public Countries Countries { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public AppUsers User { get; set; }
    }
}
