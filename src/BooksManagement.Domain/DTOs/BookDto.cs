using BooksManagement.Domain.Enuns;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksManagement.Domain.DTOs
{
    public class BookDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public long AuthorId { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Synopsis { get;  set; }
        public decimal PriceAverage { get;  set; }
        public decimal Classification { get; set; }
        public AuthorDto Author { get; set; }
        public ICollection<BookGenreDto> BookGenres { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Status Status { get; set; }
    }
}
