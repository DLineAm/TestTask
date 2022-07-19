using Microsoft.EntityFrameworkCore;
using TestTask.Shared;

namespace TestTask.Server.DAL.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Division> Divisions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Division>(entity =>
            {
                entity.ToTable("Division");

                entity.Property(p => p.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                entity.HasKey(d => d.Id);

                entity.Property(d => d.Title)
                    .HasColumnType("nvarchar(150)");
                entity.Property(d => d.Description)
                    .HasColumnType("nvarchar(MAX)");

                entity.HasOne(d => d.ParentDivision)
                    .WithMany(p => p.SubDivisions)
                    .HasForeignKey(d => d.DivisionId)
                    .OnDelete(DeleteBehavior.NoAction);

                entity.Navigation(d => d.Employees).AutoInclude();
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.HasKey(p => p.Id);

                entity.Property(p => p.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                entity.Property(d => d.FirstName)
                    .HasColumnType("nvarchar(50)")
                    .IsRequired();
                entity.Property(d => d.MiddleName)
                    .HasColumnType("nvarchar(50)");
                entity.Property(d => d.LastName)
                    .HasColumnType("nvarchar(50)")
                    .IsRequired();

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DivisionId)
                    .OnDelete(DeleteBehavior.NoAction);

                entity.Navigation(d => d.Division).AutoInclude();
            });
        }
    }
}