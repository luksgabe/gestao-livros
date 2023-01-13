using BooksManagement.Domain.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BooksManagement.App.Interfaces
{
    public interface IGenreApp
    {
        Task<IEnumerable<GenreDto>> GetGenres();
        Task Create(GenreDto genre);
    }
}
