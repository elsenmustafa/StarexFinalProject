using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarexFinalProject.Interfaces
{
    public interface IBaseRepstory<T> where T:class
    {
        List<T> GetAll();
        bool Add(T entity);
        bool Delete(T entity);
        bool Update(T entity);
    }
}
