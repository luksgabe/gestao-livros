using BooksManagement.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace BooksManagement.Domain.Interfaces.IServices
{
    public interface IAuthorService
    {
        IQueryable<Author> GetAuthors();
        Task<Author> GetById(long id);
        Task<Author> Create(Author author);
        Task Update(Author author);
        Task Delete(long id);
    }
}
