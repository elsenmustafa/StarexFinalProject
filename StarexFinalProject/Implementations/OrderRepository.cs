using StarexFinal.Data;
using StarexFinalProject.Contexts;
using StarexFinalProject.Interfaces;
using StarexFinalProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarexFinalProject.Implementations
{
    public class OrderRepository : BaseRepstory<Orders>,IOrderRepository
    {
        public OrderRepository(StarexDbContext dbContext):base(dbContext)
        {
            
        }
    }
}
