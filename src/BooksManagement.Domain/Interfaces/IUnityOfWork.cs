using BooksManagement.Domain.Interfaces.IReposiories;

namespace BooksManagement.Domain.Interfaces
{
    public interface IUnityOfWork
    {
        IAuthorRepository authorRepository { get; }
        IBookRepository bookRepository { get; }
        IGenreRepository genreRepository { get; }
        IUserRepository userRepository { get; }
        IBookGenreRepository bookGenreRepository { get; }
    }
}
