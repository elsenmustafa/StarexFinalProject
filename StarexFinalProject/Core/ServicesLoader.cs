using Microsoft.AspNetCore.Identity;
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

            services.AddIdentity<AppUsers, IdentityRole>()
                .AddEntityFrameworkStores<StarexDbContext>();
            //services.Load();
            services.AddIdentity<AppUsers, IdentityRole>(
               options =>
               {

                   //option.Password.RequireUppercase = false;
                   //option.Password.RequireNonAlphanumeric = false;


               }).AddEntityFrameworkStores<StarexDbContext>().AddDefaultTokenProviders();

        }
    }
}
