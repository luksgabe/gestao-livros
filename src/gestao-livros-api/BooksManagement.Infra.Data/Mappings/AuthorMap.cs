using BooksManagement.Domain.Entities;
using BooksManagement.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BooksManagement.Infra.Data.Mappings
{
    public class AuthorMap : IEntityTypeConfiguration<Author>, IMapping
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Author");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id)
                .HasColumnName("id").IsRequired().ValueGeneratedOnAdd();

            builder.Property(c => c.Name)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired().HasColumnName("name");

            builder.Property(c => c.Status).HasColumnName("status").HasColumnType("smallint");

            builder.Property(c => c.CreatedAt).HasColumnName("created_at");
            
            builder.Property(c => c.UpdatedAt).HasColumnName("updated_at");

            builder.HasMany(b => b.Books).WithOne(b => b.Author).HasForeignKey(b => b.AuthorId);
        }
    }
}
