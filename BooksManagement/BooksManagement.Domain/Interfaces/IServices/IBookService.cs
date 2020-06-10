using BooksManagement.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace BooksManagement.Domain.Interfaces.IServices
{
    public interface IBookService
    {
        IQueryable<Book> GetBooks();
        Task Create(Book book);
        Task<Book> GetBook(long id);
    }
}
