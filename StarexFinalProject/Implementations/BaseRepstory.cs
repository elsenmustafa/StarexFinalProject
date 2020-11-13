using StarexFinalProject.Contexts;
using StarexFinalProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarexFinalProject.Implementations
{
    public class BaseRepstory<T> : IBaseRepstory<T> where T : class
    {
        private StarexDbContext _starexDbContext;
        public BaseRepstory(StarexDbContext starexDbContext)
        {
            _starexDbContext = starexDbContext;
        }
        public bool Add(T entity)
        {
            _starexDbContext.Add<T>(entity);
            return _starexDbContext.SaveChanges() > 0;
        }

        public bool Delete(T entity)
        {
            _starexDbContext.Remove<T>(entity);
            return _starexDbContext.SaveChanges() > 0;
        }

        public List<T> GetAll()
        {
            return _starexDbContext.Set<T>().ToList();
        }

        public bool Update(T entity)
        {
            _starexDbContext.Update<T>(entity);
            return _starexDbContext.SaveChanges() > 0;
        }
    }
}
