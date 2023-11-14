using BooksManagement.App.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BooksManagement.App.Interfaces
{
    public interface IGenreApp
    {
        Task<IEnumerable<GenreViewModel>> GetGenres();
        Task Create(GenreViewModel genre);
    }
}
