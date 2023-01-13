using BooksManagement.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace BooksManagement.Domain.Interfaces.IServices
{
    public interface IAuthorService
    {
        IQueryable<Author> GetAuthors();
        Task<Author> Create(Author author);
    }
}
