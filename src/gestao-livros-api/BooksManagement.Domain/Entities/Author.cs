using System.Collections.Generic;

namespace BooksManagement.Domain.Entities
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
