using BooksManagement.Domain.Entities;
using BooksManagement.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace BooksManagement.Infra.Data.Mappings
{
    public class BookGenreMap : IEntityTypeConfiguration<BookGenre>, IMapping
    {
        public void Configure(EntityTypeBuilder<BookGenre> builder)
        {
            builder.ToTable("Book_Genres");
            
            builder.HasKey(bg => new { bg.BookId, bg.GenreId });

            builder.Property(b => b.GenreId).HasColumnName("genre_id");
            
            builder.Property(b => b.BookId).HasColumnName("book_id");

            builder.HasOne(bg => bg.Book)
                .WithMany(b => b.BookGenres)
                .HasForeignKey(bg => bg.BookId);

            builder.HasOne(bg => bg.Genre)
                .WithMany(g => g.BookGenres)
                .HasForeignKey(bg => bg.GenreId);
        }
    }
}
