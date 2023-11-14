using BooksManagement.App.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BooksManagement.App.Interfaces
{
    public interface IAuthorApp
    {
        Task<IEnumerable<AuthorViewModel>> GetAll();
        Task<AuthorViewModel> GetById(long id);
        Task Create(AuthorViewModel author);
        Task Update(AuthorViewModel author);
        Task Delete(long id);
    }
}
