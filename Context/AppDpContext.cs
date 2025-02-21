using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Efcore2.Enitities;
using Microsoft.EntityFrameworkCore;

namespace Efcore2.Context
{
    internal class AppDpContext:DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Employee>().HasKey("Id");
            modelBuilder.Entity<Employee>().HasKey(E=>E.Id);
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = AppDbG02 ; trusted_Connection = True ;  TrustServerCertificate  = True");
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
