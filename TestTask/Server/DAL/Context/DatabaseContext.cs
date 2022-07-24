using Microsoft.EntityFrameworkCore;
using TestTask.Server.DAL.Context.Configurations;
using TestTask.Shared;

namespace TestTask.Server.DAL.Context
{
    /// <summary>
    /// Контекст для работы с бд
    /// </summary>
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Division> Divisions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DivisionConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        }
    }
}