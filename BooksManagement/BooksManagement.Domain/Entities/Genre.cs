using System.Collections.Generic;

namespace BooksManagement.Domain.Entities
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<BookGenre> BookGenres { get; set; }
    }
}
