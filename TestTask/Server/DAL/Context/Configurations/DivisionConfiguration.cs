using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using TestTask.Shared;

namespace TestTask.Server.DAL.Context.Configurations
{
    /// <summary>
    /// Конфигурация таблицы "Division"
    /// </summary>
    public class DivisionConfiguration : IEntityTypeConfiguration<Division>
    {
        public void Configure(EntityTypeBuilder<Division> builder)
        {
            builder.ToTable("Division");

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("int");

            builder.HasKey(d => d.Id);

            builder.Property(d => d.Title)
                .HasColumnType("nvarchar(150)");
            builder.Property(d => d.Description)
                .HasColumnType("nvarchar(MAX)");

            builder.HasOne(d => d.ParentDivision)
                .WithMany(p => p.SubDivisions)
                .HasForeignKey(d => d.DivisionId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Navigation(d => d.Employees).AutoInclude();
        }
    }
}