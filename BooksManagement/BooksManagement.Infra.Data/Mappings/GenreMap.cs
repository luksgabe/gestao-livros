using BooksManagement.Domain.Entities;
using BooksManagement.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BooksManagement.Infra.Data.Mappings
{
    public class GenreMap : IEntityTypeConfiguration<Genre>, IMapping
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("Genre");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id)
                .HasColumnName("id").IsRequired().ValueGeneratedOnAdd();

            builder.Property(c => c.Name)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired().HasColumnName("title");

            builder.Property(c => c.Status).HasColumnName("status").HasColumnType("smallint");

            builder.Property(c => c.CreatedAt).HasColumnName("created_at");

            builder.Property(c => c.UpdatedAt).HasColumnName("updated_at");

        }
    }
}
