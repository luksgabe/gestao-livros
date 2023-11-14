using BooksManagement.App.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BooksManagement.App.Interfaces
{
    public interface IBookApp
    {
        Task<IEnumerable<BookViewModel>> GetBooks();
        Task<BookViewModel> GetBook(long id);
        Task Create(BookViewModel bookDto);
    }
}
