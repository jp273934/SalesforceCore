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
    }
}