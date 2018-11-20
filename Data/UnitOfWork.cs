using SalesforceCore.Data.Models;
using SalesforceCore.Data.Repositories;
using SalesforceCore.Data.Repositories.Interfaces;

namespace SalesforceCore.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRepository<Account> accounts { get; set; }
        
        
        public UnitOfWork(SalesAppContext context)
        {
             accounts = new Repository<Account>(context);
        }
    }
}