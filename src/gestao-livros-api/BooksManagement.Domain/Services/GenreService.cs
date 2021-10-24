using System;
using System.Linq;
using System.Threading.Tasks;
using BooksManagement.Domain.Entities;
using BooksManagement.Domain.Enuns;
using BooksManagement.Domain.Interfaces;
using BooksManagement.Domain.Interfaces.IServices;

namespace BooksManagement.Domain.Services
{
    public class GenreService : IGenreService
    {
        private readonly IUnityOfWork _unityOfWork;

        public GenreService(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        public async Task Create(Genre genre)
        {
            await _unityOfWork.genreRepository.AddAsync(genre);
            _unityOfWork.authorRepository.SaveChanges();
        }

        public IQueryable<Genre> GetGenres()
        {
            return _unityOfWork.genreRepository.GetAll();
        }
    }
}
