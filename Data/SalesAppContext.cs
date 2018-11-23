using Microsoft.EntityFrameworkCore;
using SalesforceCore.Data.Models;

namespace SalesforceCore.Data
{
    public class SalesAppContext : DbContext
    {
        public SalesAppContext(DbContextOptions<SalesAppContext> options) : base(options)
        {
            
        }     

        public DbSet<Account> Accounts { get; set; } 
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<TaskType> TaskTypes { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}