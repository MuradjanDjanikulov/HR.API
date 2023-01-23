using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DataAccess.Entity;

namespace DataAccess
{
//    public class AppDbContext : DbContext
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

 //           modelBuilder.Entity<Employee>().Property(e => e.Email).HasDefaultValueSql("'test@mail.com'");

 //           modelBuilder.Entity<Address>().HasData(new Address(999, "Navoiy street", "UZB", "TASH"));

            //Add-Migration and Update-Databse
        }
    }
}