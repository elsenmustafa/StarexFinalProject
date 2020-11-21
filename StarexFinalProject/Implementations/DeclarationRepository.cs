using StarexFinal.Data;
using StarexFinalProject.Contexts;
using StarexFinalProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarexFinalProject.Implementations
{
    public class DeclarationRepository : BaseRepstory<Declarations>, IDeclarationRepository
    {
        public DeclarationRepository(StarexDbContext dbContext) : base(dbContext)
        {

        }
    }
}
