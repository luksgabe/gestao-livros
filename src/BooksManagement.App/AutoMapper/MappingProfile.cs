using AutoMapper;
using BooksManagement.App.ViewModels;
using BooksManagement.Domain.Entities;
using System.Collections.Generic;

namespace BooksManagement.App.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Author, AuthorViewModel>().ReverseMap();

            //CreateMap<List<AuthorViewModel>, List<AuthorViewModel>>().ReverseMap();

            CreateMap<BookViewModel, Book>().ReverseMap();

            //CreateMap<List<BookViewModel>, List<Book>>().ReverseMap();

            CreateMap<GenreViewModel, Genre>().ReverseMap();

            //CreateMap<List<GenreViewModel>, List<Genre>>().ReverseMap();

            CreateMap<BookGenreViewModel, BookGenre>().ReverseMap();
            //CreateMap<List<BookGenreViewModel>, List<BookGenre>>().ReverseMap();

            CreateMap<UserViewModel, User>().ReverseMap();

            //CreateMap<List<UserViewModel>, List<User>>().ReverseMap();
        }
    }
}
