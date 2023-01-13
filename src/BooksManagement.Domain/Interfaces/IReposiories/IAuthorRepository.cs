using BooksManagement.Domain.Entities;
using System.Threading.Tasks;

namespace BooksManagement.Domain.Interfaces.IReposiories
{
    public interface IAuthorRepository : IRepository<Author>
    {

        new Task<Author> AddAsync(Author author);
    }
}
