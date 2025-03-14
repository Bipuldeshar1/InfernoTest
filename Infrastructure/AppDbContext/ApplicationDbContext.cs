using Domain.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.AppDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }

        public DbSet<Employee> employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
        
            modelBuilder.Entity<Employee>()
                    .ToTable("Employee")
                    .HasKey(e => e.Id);
        }


    }
}
