using SimpleApp.Core.Models;
using System.Collections.Generic;

namespace SimpleApp.Core.Interfaces
{
    public interface IRepository<T> where T : EntityBase
    {
        T GetById(int id);
        IEnumerable<T> List();
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
