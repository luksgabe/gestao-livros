using BooksManagement.Domain.Entities;
using BooksManagement.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BooksManagement.Infra.Data.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>, IMapping
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id)
                .HasColumnName("id").IsRequired().ValueGeneratedOnAdd();

            builder.Property(c => c.Name)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired().HasColumnName("name");

            builder.Property(c => c.LastName)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired().HasColumnName("last_name");

            builder.Property(c => c.Email)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired().HasColumnName("email");

            builder.Property(c => c.Password)
                .HasColumnType("varchar(15)")
                .HasMaxLength(100)
                .IsRequired().HasColumnName("password");

            builder.Property(c => c.Status).HasColumnName("status").HasColumnType("smallint");

            builder.Property(c => c.CreatedAt).HasColumnName("created_at");

            builder.Property(c => c.UpdatedAt).HasColumnName("updated_at");
        }
    }
}
