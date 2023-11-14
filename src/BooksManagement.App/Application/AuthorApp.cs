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
    public class AuthorApp : IAuthorApp
    {
        private readonly IMapper _mapper;
        public readonly IAuthorService _authorService;

        public AuthorApp(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AuthorViewModel>> GetAll()
        {
            return await Task.Run(() => _authorService.GetAuthors().ProjectTo<AuthorViewModel>(_mapper.ConfigurationProvider)) ;
        }

        public async Task<AuthorViewModel> GetById(long id)
        {
            return _mapper.Map<AuthorViewModel>(await _authorService.GetById(id));
        }

        public async Task Create(AuthorViewModel author)
        {
            var entity = _mapper.Map<Author>(author);
            entity.NewBook();
            await _authorService.Create(entity);
        }

        public async Task Update(AuthorViewModel viewModel)
        {
            var entity = _mapper.Map<Author>(viewModel);
            entity.Update();
            await _authorService.Update(entity);
        }

        public async Task Delete(long id)
        {
            await _authorService.Delete(id);
        }
    }
}
