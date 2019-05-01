using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VuetAPI.Models
{
    interface IRepository<T>
    {
        T Item(int id);
        IEnumerable<T> All();
        IEnumerable<T> AllWhere(Func<T, bool> predicate);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
