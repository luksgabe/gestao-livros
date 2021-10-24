namespace BooksManagement.Domain.Entities
{
    public class BookGenre
    {
        public long BookId { get; private set; }
        public virtual Book Book { get; private set; }
        public long GenreId { get; private set; }
        public virtual Genre Genre { get; private set; }

        public BookGenre(long bookId, long genreId)
        {
            BookId = bookId;
            GenreId = genreId;
        }

    }
}
