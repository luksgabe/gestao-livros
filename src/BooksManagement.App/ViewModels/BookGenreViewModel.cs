using BooksManagement.Domain.Enuns;
using System;

namespace BooksManagement.App.ViewModels
{
    public class BookGenreViewModel
    {
        public long BookId { get; set; }
        public BookViewModel Book { get; set; }
        public long GenreId { get; set; }
        public GenreViewModel Genre { get; set; }
    }
}
