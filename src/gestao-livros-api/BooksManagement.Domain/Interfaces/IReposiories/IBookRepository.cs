using BooksManagement.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BooksManagement.Domain.Interfaces.IReposiories
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<IEnumerable<Book>> GetAllBooks();
        Book LastBookCreatedAsync();
        new Book Add(Book obj);
        new Task<Book> AddAsync(Book obj);
    }
}
