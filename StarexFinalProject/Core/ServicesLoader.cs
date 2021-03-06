﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StarexFinal.Models;
using StarexFinalProject.Contexts;
using StarexFinalProject.Implementations;
using StarexFinalProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarexFinalProject.Core
{
    public static class ServicesLoader
    {
        public static void Load(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
        }
        public static void CreateIdentity(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<StarexDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("StarexProject")));

            services.AddDbContext<StarexDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("StarexProject")));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IDeclarationRepository, DeclarationRepository>();
            services.AddScoped<IDeclarationsStatusRepository, DeclarationsStatusRepository>();
            services.AddIdentity<AppUsers, IdentityRole>(
                option =>
                {
                    option.Password.RequireUppercase = false;
                    option.Password.RequireNonAlphanumeric = false;


                }).AddEntityFrameworkStores<StarexDbContext>();
            services.AddScoped<IUserRepository, UserRepository>();

        }
    }
}
