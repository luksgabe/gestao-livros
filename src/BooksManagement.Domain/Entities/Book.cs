using System.Collections.Generic;

namespace BooksManagement.Domain.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }

        public long AuthorId { get; set; }

        public virtual Author Author { get; set; }

        public virtual ICollection<BookGenre> BookGenres { get; set; }
    }
}
