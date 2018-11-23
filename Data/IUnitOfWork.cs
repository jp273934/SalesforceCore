using SalesforceCore.Data.Models;
using SalesforceCore.Data.Repositories.Interfaces;

namespace SalesforceCore.Data
{
    public interface IUnitOfWork
    {
         IRepository<Account> accounts { get; set; }
         IRepository<Contact> contacts { get; set; }
         IRepository<TaskType> tasktypes { get; set; }
         IRepository<Task> tasks { get; set; }
         IRepository<Campaign> campaigns { get; set; }
         IRepository<Project> projects { get; set; }
    }
}