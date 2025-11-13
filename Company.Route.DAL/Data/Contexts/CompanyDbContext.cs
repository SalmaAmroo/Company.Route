using Company.Route.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;


namespace Company.Route.DAL.Data.Contexts
{
    internal class CompanyDbContext:DbContext
    {
        // Constructor To open Connection to Database
        public CompanyDbContext():base()
        {

        }
        // to configure the model
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        // Open Connection to Database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Srver:.;Database = CompanyProjct;Trusted_Connection = True;TrustedServerCertificate=True");
        }

        // Map Models to Database Tables
        public DbSet<Department> Departments { get; set; }
    }
}
