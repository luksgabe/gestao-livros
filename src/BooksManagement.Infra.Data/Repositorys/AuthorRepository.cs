using BooksManagement.Domain.Entities;
using BooksManagement.Domain.Interfaces.IReposiories;
using BooksManagement.Infra.Data.Context;

namespace BooksManagement.Infra.Data.Repositorys
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
