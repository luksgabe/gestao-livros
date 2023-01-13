using BooksManagement.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace BooksManagement.Domain.Interfaces.IServices
{
    public interface IGenreService
    {
        IQueryable<Genre> GetGenres();
        Task Create(Genre genre);
    }
}
