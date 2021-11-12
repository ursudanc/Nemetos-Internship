using Company.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Services
{
    public class CompanyDbContext : DbContext
    {
        
        public DbSet<Employee> Employee { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<CompanyDbContext>(null);
            base.OnModelCreating(modelBuilder);
        }

    }
}
