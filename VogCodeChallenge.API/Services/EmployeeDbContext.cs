using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VogCodeChallenge.API.Domain;

namespace VogCodeChallenge.API.Services
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Company> Companies { get; set; }

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
//            builder.Entity<Employee>()
//            //.HasOne(x => x.department)
//            //.WithMany()
/*            .HasForeignKey(x => x.Id);

            builder.Entity<Department>()
            .HasOne(x => x.Employees)
            .WithMany()
            .HasForeignKey(x => x.Id);

            builder.Entity<Department>()
            .HasOne(x => x.company)
            .WithMany()
            .HasForeignKey(x => x.companyToken);


            builder.Entity<Department>()
                .HasIndex(u => u.Address)
                .IsUnique();
*/        }
    }
}
