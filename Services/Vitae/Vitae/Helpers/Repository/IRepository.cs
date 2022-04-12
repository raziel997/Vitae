using System.Collections.Generic;

namespace Vitae.Helpers.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> Get();
        T Get(int Oid);
        void Add(T item);
        void Delete(int Oid);
        void Update(T item);
        void Save();
    }
}