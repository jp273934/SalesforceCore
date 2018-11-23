using SalesforceCore.Data.Models;
using SalesforceCore.Data.Repositories.Interfaces;

namespace SalesforceCore.Data
{
    public interface IUnitOfWork
    {
         IRepository<Account> accounts { get; set; }
         IRepository<Contact> contacts { get; set; }
         IRepository<TaskType> tasktypes { get; set; }
    }
}