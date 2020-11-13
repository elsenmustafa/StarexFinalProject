using StarexFinal.Data;
using StarexFinalProject.Contexts;
using StarexFinalProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarexFinalProject.Implementations
{
    public class CountriesRepstory : BaseRepstory<Countries>, ICountriesRepsotory
    {
        public CountriesRepstory(StarexDbContext starexDbContext) : base(starexDbContext)
        {
         
        }
    }
}
