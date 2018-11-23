using SalesforceCore.Data.Models;
using SalesforceCore.Data.Repositories;
using SalesforceCore.Data.Repositories.Interfaces;

namespace SalesforceCore.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRepository<Account> accounts { get; set; }
        public IRepository<Contact> contacts { get; set; }
        public IRepository<TaskType> tasktypes { get; set; }
        public IRepository<Task> tasks { get; set; }
        public IRepository<Campaign> campaigns { get; set; }
        public IRepository<Project> projects { get; set; }

        public UnitOfWork(SalesAppContext context)
        {
             accounts = new Repository<Account>(context);
             contacts = new Repository<Contact>(context);
             tasktypes = new Repository<TaskType>(context);
             tasks = new Repository<Task>(context);
             campaigns = new Repository<Campaign>(context);
             projects = new Repository<Project>(context);
        }
    }
}