using Microsoft.EntityFrameworkCore;
using PMRU.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Persistence
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Employee>()
                .HasKey(e => e.RegistrationNo);

        }
    }
}
