using BooksManagement.Domain.Entities;
using BooksManagement.Domain.Interfaces.IReposiories;
using BooksManagement.Infra.Data.Context;

namespace BooksManagement.Infra.Data.Repositorys
{
    public class BookGenreRepository : Repository<BookGenre>, IBookGenreRepository
    {
        public BookGenreRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
