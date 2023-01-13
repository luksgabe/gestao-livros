using BooksManagement.Domain.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BooksManagement.App.Interfaces
{
    public interface IAuthorApp
    {
        Task<IEnumerable<AuthorDto>> GetAuthors();
        Task Create(AuthorDto author);
    }
}
