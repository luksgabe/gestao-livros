using BooksManagement.Domain.Entities;
using System.Threading.Tasks;

namespace BooksManagement.Domain.Interfaces.IReposiories
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<Book> LastBookCreatedAsync();
    }
}
