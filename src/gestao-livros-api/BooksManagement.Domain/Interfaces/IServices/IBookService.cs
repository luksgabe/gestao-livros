using BooksManagement.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BooksManagement.Domain.Interfaces.IServices
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetBooks();
        Task Create(Book book);
        Task<Book> GetBook(long id);
    }
}
