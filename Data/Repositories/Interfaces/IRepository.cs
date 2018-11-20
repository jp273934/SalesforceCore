using System.Collections.Generic;

namespace SalesforceCore.Data.Repositories.Interfaces
{
    public interface IRepository<T> 
    {
         IEnumerable<T> Get();
         T GetById(int id);
    }
}