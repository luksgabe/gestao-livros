using BooksManagement.Domain.Enuns;
using System;
using System.Collections.Generic;

namespace BooksManagement.App.ViewModels
{
    public class BookViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public long AuthorId { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Synopsis { get;  set; }
        public decimal PriceAverage { get;  set; }
        public decimal Classification { get; set; }
        public AuthorViewModel Author { get; set; }
        public ICollection<BookGenreViewModel> BookGenres { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Status Status { get; set; }
    }
}
