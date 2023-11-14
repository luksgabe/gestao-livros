using System;
using System.Linq;
using System.Threading.Tasks;
using BooksManagement.Domain.Entities;
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

        public async Task<Author> GetById(long id)
        {
            return await _unityOfWork.authorRepository.GetByIdAsync(id);
        }

        public async Task<Author> Create(Author author)
        {
            var result = await _unityOfWork.authorRepository.AddAsync(author);
            _unityOfWork.authorRepository.SaveChanges();
            return result;
        }

        public async Task Update(Author author)
        {
            await _unityOfWork.authorRepository.UpdateAsync(author);
            _unityOfWork.authorRepository.SaveChanges();
        }

        public async Task Delete(long id)
        {
            await Task.Run(() => _unityOfWork.authorRepository.Remove(id));
            _unityOfWork.authorRepository.SaveChanges();
        }
    }
}
