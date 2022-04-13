using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Vitae.Models;

namespace Vitae.Helpers.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private vitaeContext _context;
        private DbSet<T> _dbSet;

        public Repository(vitaeContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public IEnumerable<T> Get() => _dbSet.ToList();

        public T Get(int Oid) => _dbSet.Find(Oid);

        public void Add(T item) => _dbSet.Add(item);

        public void Delete(int Oid) =>_dbSet.Remove(_dbSet.Find(Oid));

        public void Save() => _context.SaveChanges();

        public void Update(T item)
        {
            _dbSet.Attach(item);
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
