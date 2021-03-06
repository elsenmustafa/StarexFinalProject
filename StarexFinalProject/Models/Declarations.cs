﻿using Microsoft.AspNetCore.Http;
using StarexFinal.Models;
using StarexFinalProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StarexFinal.Data
{
    public class Declarations
    {
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[Required]
		public int CountryId { get; set; }

		[Required]
		public string TrackingCode { get; set; }

		[Required]
		public string Shop { get; set; }

		[Required]
		public string ProductType { get; set; }

		[Required]
		public bool LiquidOrNot { get; set; }

		[Required]
		public int Quantity { get; set; }

		[Required]
		public decimal ProductPrice { get; set; }

		[MaxLength(120)]
		public string Comment { get; set; }

		[Required]
		public string FileName { get; set; }

		[Required]
		[NotMapped]
		public IFormFile File { get; set; }

		[Required]
		public string DeliveryCode { get; set; }

		[Required]
		public string OrderNumber { get; set; }

		public decimal ShippingPrice { get; set; }
		public decimal ProductWeight { get; set; }

		[Required]
		public int Warehouse_Id { get; set; }
		[Required]
		public DateTime DeclarationDate { get; set; }
		public int StatusId { get; set; }
		[Required]
		public string UserId { get; set; }

		public virtual AppUsers User { get; set; }
		public virtual Warehouse Warehouse { get; set; }
		public virtual DeclarationsStatus Status { get; set; }
	}
}
