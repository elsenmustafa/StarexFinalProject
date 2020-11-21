using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StarexFinalProject.ViewModel
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string Url { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string ProductColor { get; set; }
        [Required]
        public string ProductSize { get; set; }
        [Required]
        public string Comment { get; set; }
        public int CountryId { get; set; }
        [Required]
        public decimal ProductPrice { get; set; }
        [Required]
        public decimal Cargo_Price { get; set; }
        [Required]
        public decimal Total_Price { get; set; }
        public DateTime CreatTime { get; set; }
        public int StatusId { get; set; }
        public string UserId { get; set; }
        public int TrackingCode { get; set; }
    }
}
