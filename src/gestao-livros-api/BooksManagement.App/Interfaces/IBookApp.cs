using BooksManagement.Domain.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BooksManagement.App.Interfaces
{
    public interface IBookApp
    {
        Task<IEnumerable<BookDto>> GetBooks();
        Task<BookDto> GetBook(long id);
        Task Create(BookDto bookDto);
    }
}
