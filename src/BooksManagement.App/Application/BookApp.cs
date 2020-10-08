using AutoMapper;
using AutoMapper.QueryableExtensions;
using BooksManagement.App.Interfaces;
using BooksManagement.Domain.DTOs;
using BooksManagement.Domain.Entities;
using BooksManagement.Domain.Interfaces.IServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BooksManagement.App.Application
{
    public class BookApp : IBookApp
    {
        private readonly IMapper _mapper;
        public readonly IBookService _bookService;

        public BookApp(IBookService bookService, IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;
        }

        public async Task Create(BookDto dto)
        {
            var book = _mapper.Map<Book>(dto);
            await _bookService.Create(book);
        }

        public async Task<IEnumerable<BookDto>> GetBooks()
        {
            return await Task.Run(() => _bookService.GetBooks().ProjectTo<BookDto>(_mapper.ConfigurationProvider));
        }

        public async Task<BookDto> GetBook(long id)
        {
            Book book = await _bookService.GetBook(id);
            return _mapper.Map<BookDto>(book);
        }
    }
}
