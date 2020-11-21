using StarexFinal.Models;
using StarexFinalProject.Contexts;
using StarexFinalProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarexFinalProject.Implementations
{
    public class DeclarationsStatusRepository : BaseRepstory<DeclarationsStatus>, IDeclarationsStatusRepository
    {
        public DeclarationsStatusRepository(StarexDbContext starexDbContext) : base(starexDbContext)
        {

        }
    }
}
