using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using BooksManagement.App.Interfaces;
using BooksManagement.App.ViewModels;
using BooksManagement.Domain.Entities;
using BooksManagement.Domain.Interfaces.IServices;

namespace BooksManagement.App.Application
{
    public class GenreApp : IGenreApp
    {

        private readonly IMapper _mapper;
        public readonly IGenreService _genreService;

        public GenreApp(IGenreService genreService, IMapper mapper)
        {
            _genreService = genreService;
            _mapper = mapper;
        }

        public async Task Create(GenreViewModel dto)
        {
            var genre = _mapper.Map<Genre>(dto);
            await _genreService.Create(genre);
        }

        public async Task<IEnumerable<GenreViewModel>> GetGenres()
        {
            return await Task.Run(() => _genreService.GetGenres().ProjectTo<GenreViewModel>(_mapper.ConfigurationProvider));
        }
    }
}
