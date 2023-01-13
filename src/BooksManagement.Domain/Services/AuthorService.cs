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

        public async Task<Author> Create(Author author)
        {
            var result = await _unityOfWork.authorRepository.AddAsync(author);
            _unityOfWork.authorRepository.SaveChanges();
            return result;
        }
    }
}
