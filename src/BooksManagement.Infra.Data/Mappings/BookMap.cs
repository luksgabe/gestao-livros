﻿using BooksManagement.Domain.Entities;
using BooksManagement.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BooksManagement.Infra.Data.Mappings
{
    public class BookMap : IEntityTypeConfiguration<Book>, IMapping
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id)
                .HasColumnName("id").IsRequired().ValueGeneratedOnAdd();

            builder.Property(c => c.Title)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired().HasColumnName("title");

            builder.Property(c => c.Synopsis)
                .HasColumnType("varchar(256)")
                .HasMaxLength(256)
                .IsRequired().HasColumnName("synopse");

            builder.Property(c => c.Classification)
                .HasColumnType("decimal(5,2)")
                .IsRequired().HasColumnName("classification");

            builder.Property(c => c.PriceAverage)
                .HasColumnType("decimal(5,2)")
                .IsRequired().HasColumnName("price_average");

            builder.Property(c => c.PublicationDate).HasColumnName("publication_date");

            builder.Property(c => c.Status).HasColumnName("status").HasColumnType("smallint");

            builder.Property(c => c.CreatedAt).HasColumnName("created_at");

            builder.Property(c => c.UpdatedAt).HasColumnName("updated_at");
            
            builder.Property(c => c.AuthorId).HasColumnName("author_id");

            builder.HasOne(b => b.Author).WithMany(a => a.Books).HasForeignKey(b => b.AuthorId);
        }
    }
}
