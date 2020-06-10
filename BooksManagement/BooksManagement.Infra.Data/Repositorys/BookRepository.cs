using BooksManagement.Domain.Entities;
using BooksManagement.Domain.Interfaces.IReposiories;
using BooksManagement.Infra.Data.Context;
using System.Threading.Tasks;
using System.Linq;

namespace BooksManagement.Infra.Data.Repositorys
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(ApplicationDbContext context) : base(context)
        {
            context.ChangeTracker.LazyLoadingEnabled = true;
        }

        public async Task<Book> LastBookCreatedAsync()
        {
            var idMax = await Task.Run(() => GetAll().Max(p => p.Id));
            return await Task.Run(() => GetAll().FirstOrDefault(p => p.Id == idMax));
        }
    }
}
