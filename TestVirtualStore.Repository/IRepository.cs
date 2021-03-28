using System;
using System.Collections.Generic;
using System.Text;
using TestVirtualStore.DataAccess;

namespace TestVirtualStore.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
