using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SalesforceCore.Data.Repositories.Interfaces;

namespace SalesforceCore.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public IEnumerable<T> Get()
        {
            return _context.Set<T>();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
    }
}