using BooksManagement.Domain.Entities;
using BooksManagement.Domain.Interfaces.IReposiories;
using BooksManagement.Infra.Data.Context;
using System.Threading.Tasks;

namespace BooksManagement.Infra.Data.Repositorys
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(ApplicationDbContext context) : base(context)
        {
        }

        public new async Task<Author> AddAsync(Author author)
        {
            var set = _context.Set<Author>();
            var result = await set.AddAsync(author);

            await _context.SaveChangesAsync();
            return null;
        }
    }
}
