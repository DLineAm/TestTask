using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestTask.Shared;

namespace TestTask.Server.DAL.Context.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("int");

            builder.Property(d => d.FirstName)
                .HasColumnType("nvarchar(50)")
                .IsRequired();
            builder.Property(d => d.MiddleName)
                .HasColumnType("nvarchar(50)");
            builder.Property(d => d.LastName)
                .HasColumnType("nvarchar(50)")
                .IsRequired();

            builder.HasOne(d => d.Division)
                .WithMany(p => p.Employees)
                .HasForeignKey(d => d.DivisionId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Navigation(d => d.Division).AutoInclude();
        }
    }
}