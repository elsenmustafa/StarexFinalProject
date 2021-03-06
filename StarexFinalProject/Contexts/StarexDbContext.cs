﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StarexFinal.Data;
using StarexFinal.Models;
using StarexFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarexFinalProject.Contexts
{
    public class StarexDbContext : IdentityDbContext<AppUsers>
    {
        public StarexDbContext(DbContextOptions<StarexDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Countries>().HasData(
              new Countries() { Id = 1, Name = "USA" },
               new Countries() { Id = 2, Name = "Turkey" },
                new Countries() { Id = 3, Name = "China" }
             );
            builder.Entity<Currency>().HasData(
              new Currency() { Id = 1, Name = "USD" },
                new Currency() { Id = 2, Name = "TRY" }
             );
            builder.Entity<Warehouse>().HasData(
           new Warehouse() { Id = 1, Adress = "BAKI - Gənclik: (Atatürk prospekti, 4A, Gənclik metrosunun yanı)" },
            new Warehouse() { Id = 2, Adress = "BAKI - Xalqlar Dostluğu: (Xətai rayonu, Məhəmməd Hadi küçəsi 2)" },
             new Warehouse() { Id = 3, Adress = "BAKI - İnşaatçılar: (Şərifzadə küçəsi 174)" },
              new Warehouse() { Id = 4, Adress = "SUMQAYIT: (Bakı küçəsi 107, Aviakassanın yanı)" },
               new Warehouse() { Id = 5, Adress = "GƏNCƏ: (Nəriman Nərimanov küçəsi 298F, Köhnə Yevlax avtovağzalı ilə üzbəüz)" }
          );
            builder.Entity<OrderStatus>().HasData(
             new OrderStatus() { Id = 1, Name = "unpaid" },
              new OrderStatus() { Id = 2, Name = "paid" },
               new OrderStatus() { Id = 3, Name = "ordered" },
                new OrderStatus() { Id = 4, Name = "deleted" }
            );
            builder.Entity<DeclarationsStatus>().HasData(
          new DeclarationsStatus() { Id = 1, Name = "declared" },
           new DeclarationsStatus() { Id = 2, Name = "inForeignWarehouse" },
            new DeclarationsStatus() { Id = 3, Name = "onTheWay" },
             new DeclarationsStatus() { Id = 4, Name = "inLocalWarehouse" },
              new DeclarationsStatus() { Id = 5, Name = "delivered" }
         );
            builder.Entity<FormCategory>().HasData(
            new FormCategory() { Id = 1, Name = "Sifariş haqqında məlumat" },
             new FormCategory() { Id = 2, Name = "Tapılmayan bağlama" },
              new FormCategory() { Id = 3, Name = "Hesabımda mənə məxsus olmayan bağlama" },
               new FormCategory() { Id = 4, Name = "Sifarişin alınması" },
                new FormCategory() { Id = 5, Name = "Bağlamanın gecikməsi" },
                 new FormCategory() { Id = 6, Name = "Yanlış gələn sifariş" },
                  new FormCategory() { Id = 7, Name = "Tapılmayan bağlama" },
                   new FormCategory() { Id = 8, Name = "Geri qaytarilma" },
                    new FormCategory() { Id = 9, Name = "Balansla bağlı" },
                     new FormCategory() { Id = 10, Name = "Təklif və iradlar" },
                      new FormCategory() { Id = 11, Name = "Digər" }
           );

            builder.Entity<Product>().HasData(
           new Product() { Id = 1, CountryId = 1, ProductType = "Accsessuar" },
            new Product() { Id = 2, CountryId = 1, ProductType = "Appliances" },
             new Product() { Id = 3, CountryId = 1, ProductType = "Apps & Games" },
              new Product() { Id = 4, CountryId = 1, ProductType = "Baby" },
               new Product() { Id = 5, CountryId = 1, ProductType = "Beauty & Personal Care" },
                new Product() { Id = 6, CountryId = 1, ProductType = "Books" },
                 new Product() { Id = 7, CountryId = 1, ProductType = "Electronics" },
                  new Product() { Id = 8, CountryId = 1, ProductType = "Clothing, Shoes & Jewelry" },
                   new Product() { Id = 9, CountryId = 1, ProductType = "Home & Kitchen" },
                    new Product() { Id = 10, CountryId = 1, ProductType = "Garden & Outdoor" },

           new Product() { Id = 11, CountryId = 2, ProductType = "Aksesuar" },
            new Product() { Id = 12, CountryId = 2, ProductType = "Ayakkabi" },
             new Product() { Id = 13, CountryId = 2, ProductType = "Bebek giyim" },
              new Product() { Id = 14, CountryId = 2, ProductType = "Kadin giyim" },
               new Product() { Id = 15, CountryId = 2, ProductType = "Erkek giyim" },
                new Product() { Id = 16, CountryId = 2, ProductType = "Cilt bakim" },
                 new Product() { Id = 17, CountryId = 2, ProductType = "Ev dekorasyon" },
                  new Product() { Id = 18, CountryId = 2, ProductType = "Canta" },
                   new Product() { Id = 19, CountryId = 2, ProductType = "Gida" },
                    new Product() { Id = 20, CountryId = 2, ProductType = "Elektronik" }
          );

        }
        public DbSet<AppUsers> appUsers { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<UserBalance> UserBalances { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Declarations> Declarations { get; set; }
        public DbSet<DeclarationsStatus> DeclarationsStatuses { get; set; }
        public DbSet<FormCategory> OnlineFormCategories { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
