using Company.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Company.DAL.Data.Contexts
{
    public class CompanyDbContexts : DbContext
    {

        public CompanyDbContexts(DbContextOptions<CompanyDbContexts>options) : base(options) 
        {
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server = LAPTOP-RMICPJR7 . ; Database = Company ; Trusted_Connection = True ; TrustServerCertificate = True");
        //}
        public DbSet<Department> Departments  { get; set; }
    }
}
