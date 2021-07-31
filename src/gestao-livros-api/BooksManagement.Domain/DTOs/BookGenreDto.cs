using BooksManagement.Domain.Enuns;
using System;

namespace BooksManagement.Domain.DTOs
{
    public class BookGenreDto
    {
        public long Id { get; set; }
        public long BookId { get; set; }
        public BookDto Book { get; set; }
        public long GenreId { get; set; }
        public GenreDto Genre { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Status Status { get; set; }
    }
}
