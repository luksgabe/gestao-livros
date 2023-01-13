using BooksManagement.Domain.Interfaces;
using BooksManagement.Domain.Interfaces.IReposiories;
using BooksManagement.Infra.Data.Context;
using BooksManagement.Infra.Data.Repositorys;

namespace BooksManagement.Infra.Data.UoW
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly ApplicationDbContext _context;
        private IAuthorRepository _authorRepository;
        private IBookRepository _bookRepository;
        private IGenreRepository _genreRepository;
        private IBookGenreRepository _bookGenreRepository;
        private IUserRepository _userRepository;

        public UnityOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        IAuthorRepository IUnityOfWork.authorRepository => _authorRepository = _authorRepository ?? new AuthorRepository(_context);

        IBookRepository IUnityOfWork.bookRepository => _bookRepository = _bookRepository ?? new BookRepository(_context);

        IGenreRepository IUnityOfWork.genreRepository => _genreRepository = _genreRepository ?? new GenreRepository(_context);

        IBookGenreRepository IUnityOfWork.bookGenreRepository => _bookGenreRepository = _bookGenreRepository ?? new BookGenreRepository(_context);

        IUserRepository IUnityOfWork.userRepository => throw new System.NotImplementedException();
    }
}
