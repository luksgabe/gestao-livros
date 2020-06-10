using System;
using System.Linq;
using System.Threading.Tasks;
using BooksManagement.Domain.Entities;
using BooksManagement.Domain.Enuns;
using BooksManagement.Domain.Interfaces;
using BooksManagement.Domain.Interfaces.IServices;

namespace BooksManagement.Domain.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IUnityOfWork _unityOfWork;

        public AuthorService(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        public IQueryable<Author> GetAuthors()
        {
            return _unityOfWork.authorRepository.GetAll();
        }

        public async Task Create(Author author)
        {
            author.CreatedAt = DateTime.Now;
            author.UpdatedAt = DateTime.Now;
            author.Status = Status.Active;
            await _unityOfWork.authorRepository.AddAsync(author);
            _unityOfWork.authorRepository.SaveChanges();
        }
    }
}
