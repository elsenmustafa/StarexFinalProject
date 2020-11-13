﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StarexFinalProject.Contexts;

namespace StarexFinalProject.Migrations
{
    [DbContext(typeof(StarexDbContext))]
    partial class StarexDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("StarexFinal.Data.Countries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "USA"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Turkey"
                        },
                        new
                        {
                            Id = 3,
                            Name = "China"
                        });
                });

            modelBuilder.Entity("StarexFinal.Data.Declarations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppUsersId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CargoNumber")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountriesId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("Declaration_Amount")
                        .HasColumnType("int");

                    b.Property<string>("File")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Shop")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUsersId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CountriesId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Declarations");
                });

            modelBuilder.Entity("StarexFinal.Data.FormCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OnlineFormCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sifariş haqqında məlumat"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Tapılmayan bağlama"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Hesabımda mənə məxsus olmayan bağlama"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Sifarişin alınması"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Bağlamanın gecikməsi"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Yanlış gələn sifariş"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Tapılmayan bağlama"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Geri qaytarilma"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Balansla bağlı"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Təklif və iradlar"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Digər"
                        });
                });

            modelBuilder.Entity("StarexFinal.Data.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<decimal>("Cargo_Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountriesId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int?>("OrderStatusId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Total_Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CountriesId");

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("StarexFinal.Models.AppUsers", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GovId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GovIdPrefix")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("WarehouseId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("StarexFinal.Models.DeclarationsStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DeclarationsStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "declared"
                        },
                        new
                        {
                            Id = 2,
                            Name = "inForeignWarehouse"
                        },
                        new
                        {
                            Id = 3,
                            Name = "onTheWay"
                        },
                        new
                        {
                            Id = 4,
                            Name = "inLocalWarehouse"
                        },
                        new
                        {
                            Id = 5,
                            Name = "delivered"
                        });
                });

            modelBuilder.Entity("StarexFinal.Models.UserBalance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppUsersId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUsersId");

                    b.HasIndex("CurrencyId");

                    b.ToTable("UserBalances");
                });

            modelBuilder.Entity("StarexFinalProject.Models.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Currencies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "USD"
                        },
                        new
                        {
                            Id = 2,
                            Name = "TRY"
                        });
                });

            modelBuilder.Entity("StarexFinalProject.Models.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrderStatus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "unpaid"
                        },
                        new
                        {
                            Id = 2,
                            Name = "paid"
                        },
                        new
                        {
                            Id = 3,
                            Name = "ordered"
                        },
                        new
                        {
                            Id = 4,
                            Name = "deleted"
                        });
                });

            modelBuilder.Entity("StarexFinalProject.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("ProductType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            ProductType = "Accsessuar"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 1,
                            ProductType = "Appliances"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 1,
                            ProductType = "Apps & Games"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 1,
                            ProductType = "Baby"
                        },
                        new
                        {
                            Id = 5,
                            CountryId = 1,
                            ProductType = "Beauty & Personal Care"
                        },
                        new
                        {
                            Id = 6,
                            CountryId = 1,
                            ProductType = "Books"
                        },
                        new
                        {
                            Id = 7,
                            CountryId = 1,
                            ProductType = "Electronics"
                        },
                        new
                        {
                            Id = 8,
                            CountryId = 1,
                            ProductType = "Clothing, Shoes & Jewelry"
                        },
                        new
                        {
                            Id = 9,
                            CountryId = 1,
                            ProductType = "Home & Kitchen"
                        },
                        new
                        {
                            Id = 10,
                            CountryId = 1,
                            ProductType = "Garden & Outdoor"
                        },
                        new
                        {
                            Id = 11,
                            CountryId = 2,
                            ProductType = "Aksesuar"
                        },
                        new
                        {
                            Id = 12,
                            CountryId = 2,
                            ProductType = "Ayakkabi"
                        },
                        new
                        {
                            Id = 13,
                            CountryId = 2,
                            ProductType = "Bebek giyim"
                        },
                        new
                        {
                            Id = 14,
                            CountryId = 2,
                            ProductType = "Kadin giyim"
                        },
                        new
                        {
                            Id = 15,
                            CountryId = 2,
                            ProductType = "Erkek giyim"
                        },
                        new
                        {
                            Id = 16,
                            CountryId = 2,
                            ProductType = "Cilt bakim"
                        },
                        new
                        {
                            Id = 17,
                            CountryId = 2,
                            ProductType = "Ev dekorasyon"
                        },
                        new
                        {
                            Id = 18,
                            CountryId = 2,
                            ProductType = "Canta"
                        },
                        new
                        {
                            Id = 19,
                            CountryId = 2,
                            ProductType = "Gida"
                        },
                        new
                        {
                            Id = 20,
                            CountryId = 2,
                            ProductType = "Elektronik"
                        });
                });

            modelBuilder.Entity("StarexFinalProject.Models.Warehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Warehouse");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adress = "BAKI - Gənclik: (Atatürk prospekti, 4A, Gənclik metrosunun yanı)"
                        },
                        new
                        {
                            Id = 2,
                            Adress = "BAKI - Xalqlar Dostluğu: (Xətai rayonu, Məhəmməd Hadi küçəsi 2)"
                        },
                        new
                        {
                            Id = 3,
                            Adress = "BAKI - İnşaatçılar: (Şərifzadə küçəsi 174)"
                        },
                        new
                        {
                            Id = 4,
                            Adress = "SUMQAYIT: (Bakı küçəsi 107, Aviakassanın yanı)"
                        },
                        new
                        {
                            Id = 5,
                            Adress = "GƏNCƏ: (Nəriman Nərimanov küçəsi 298F, Köhnə Yevlax avtovağzalı ilə üzbəüz)"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("StarexFinal.Models.AppUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("StarexFinal.Models.AppUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StarexFinal.Models.AppUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("StarexFinal.Models.AppUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StarexFinal.Data.Declarations", b =>
                {
                    b.HasOne("StarexFinal.Models.AppUsers", null)
                        .WithMany("Declarations")
                        .HasForeignKey("AppUsersId");

                    b.HasOne("StarexFinal.Data.FormCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("StarexFinal.Data.Countries", "Countries")
                        .WithMany("Declarations")
                        .HasForeignKey("CountriesId");

                    b.HasOne("StarexFinalProject.Models.Warehouse", null)
                        .WithMany("Declarations")
                        .HasForeignKey("WarehouseId");
                });

            modelBuilder.Entity("StarexFinal.Data.Orders", b =>
                {
                    b.HasOne("StarexFinal.Data.Countries", "Countries")
                        .WithMany("Orders")
                        .HasForeignKey("CountriesId");

                    b.HasOne("StarexFinalProject.Models.OrderStatus", null)
                        .WithMany("Orders")
                        .HasForeignKey("OrderStatusId");

                    b.HasOne("StarexFinal.Models.AppUsers", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("StarexFinal.Models.AppUsers", b =>
                {
                    b.HasOne("StarexFinalProject.Models.Warehouse", "Warehouses")
                        .WithMany("appUsers")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StarexFinal.Models.UserBalance", b =>
                {
                    b.HasOne("StarexFinal.Models.AppUsers", "AppUsers")
                        .WithMany("UserBalance")
                        .HasForeignKey("AppUsersId");

                    b.HasOne("StarexFinalProject.Models.Currency", null)
                        .WithMany("UserBalances")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
