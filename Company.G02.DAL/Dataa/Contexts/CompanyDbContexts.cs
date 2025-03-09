using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Company.G02.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Company.G02.DAL.Dataa.Contexts
{
    internal class CompanyDbContexts : DbContext
    {
        public CompanyDbContexts() : base()
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = CompanyG02; Trusted_Connection = True ; TrustServerCertificate = True");
        }

        public DbSet<Department> Department { get; set; }
    }
}
