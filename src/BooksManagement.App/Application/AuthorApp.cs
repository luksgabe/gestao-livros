using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using BooksManagement.App.Interfaces;
using BooksManagement.Domain.DTOs;
using BooksManagement.Domain.Entities;
using BooksManagement.Domain.Interfaces.IServices;

namespace BooksManagement.App.Application
{
    public class AuthorApp : IAuthorApp
    {
        private readonly IMapper _mapper;
        public readonly IAuthorService _authorService;

        public AuthorApp(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public async Task Create(AuthorDto dto)
        {
            var author = _mapper.Map<Author>(dto);
            await _authorService.Create(author);
        }

        public async Task<IEnumerable<AuthorDto>> GetAuthors()
        {
            return await Task.Run(() => _authorService.GetAuthors().ProjectTo<AuthorDto>(_mapper.ConfigurationProvider)) ;
        }
    }
}
