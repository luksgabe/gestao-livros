using BooksManagement.Domain.Enuns;
using System;
using System.Collections.Generic;

namespace BooksManagement.Domain.DTOs
{
    public class GenreDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public ICollection<BookGenreDto> BookGenres { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Status Status { get; set; }
    }
}
