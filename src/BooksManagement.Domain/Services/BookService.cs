using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksManagement.Domain.Entities;
using BooksManagement.Domain.Enuns;
using BooksManagement.Domain.Interfaces;
using BooksManagement.Domain.Interfaces.IServices;

namespace BooksManagement.Domain.Services
{
    public class BookService : IBookService
    {
        private readonly IUnityOfWork _unityOfWork;

        public BookService(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        public async Task Create(Book book)
        {
            book.CreatedAt = DateTime.Now;
            book.UpdatedAt = DateTime.Now;
            book.Status = Status.Active;
            List<long> genresIds = null;

            var author = await _unityOfWork.authorRepository.GetByIdAsync(book.AuthorId);
            book.Author = author;

            
            //Book newBook = await _unityOfWork.bookRepository.LastBookCreatedAsync();

            if (book.BookGenres != null && book.BookGenres.Any())
            {
                genresIds = new List<long>();
                book.BookGenres.ToList().ForEach(async p => {
                    genresIds.Add(p.GenreId);
                });

                book.BookGenres = new List<BookGenre>();

                genresIds.ForEach(async idGenre =>
                {
                    Genre genre = await _unityOfWork.genreRepository.GetByIdAsync(idGenre);
                    book.BookGenres.Add(new BookGenre
                    {
                        Genre = genre,
                        Status = Status.Active,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    });
                });
            }

            await _unityOfWork.bookRepository.AddAsync(book);

            //await _unityOfWork.bookRepository.UpdateAsync(book);

            _unityOfWork.bookRepository.SaveChanges();
        }

        public async Task<Book> GetBook(long id)
        {
            return await _unityOfWork.bookRepository.GetByIdAsync(id);
        }

        public IQueryable<Book> GetBooks()
        {
            return _unityOfWork.bookRepository.GetAll();
        }
    }
}
