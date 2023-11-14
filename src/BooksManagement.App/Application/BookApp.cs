using AutoMapper;
using BooksManagement.App.Interfaces;
using BooksManagement.App.ViewModels;
using BooksManagement.Domain.Entities;
using BooksManagement.Domain.Interfaces.IServices;
using System.Collections.Generic;
using System.Linq;
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

        public async Task Create(BookViewModel dto)
        {
            var book = _mapper.Map<Book>(dto);
            await _bookService.Create(book);
        }

        public async Task<IEnumerable<BookViewModel>> GetBooks()
        {
            var result = _mapper.Map<IEnumerable<BookViewModel>>(await _bookService.GetBooks());
            return result;
        }

        public async Task<BookViewModel> GetBook(long id)
        {
            Book book = await _bookService.GetBook(id);
            return _mapper.Map<BookViewModel>(book);
        }
    }
}
