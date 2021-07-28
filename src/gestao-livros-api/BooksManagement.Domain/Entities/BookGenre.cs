namespace BooksManagement.Domain.Entities
{
    public class BookGenre : BaseEntity
    {
        public long BookId { get; set; }
        public virtual Book Book { get; set; }
        public long GenreId { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
