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

        public async Task<Book> Create(Book book)
        {
            Author author = await _unityOfWork.authorRepository.GetByIdAsync(book.AuthorId);
            book.SetAuthor(author);

            var result = await _unityOfWork.bookRepository.AddAsync(book);

            _unityOfWork.bookRepository.SaveChanges();
            return result;
        }

        public async Task<Book> GetBook(long id)
        {
            return await _unityOfWork.bookRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _unityOfWork.bookRepository.GetAllBooks();
        }
    }
}
