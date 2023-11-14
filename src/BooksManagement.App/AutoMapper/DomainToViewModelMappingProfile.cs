using AutoMapper;
using BooksManagement.App.ViewModels;
using BooksManagement.Domain.Entities;
using System.Collections.Generic;

namespace BooksManagement.App.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Author, AuthorViewModel>();
            //CreateMap<List<Author>, List<AuthorViewModel>>();

            CreateMap<Book, BookViewModel>();
            //CreateMap<List<Book>, List<BookViewModel>>();

            CreateMap<Genre, GenreViewModel>();
            //CreateMap<List<Genre>, List<GenreViewModel>>();

            CreateMap<BookGenre, BookGenreViewModel>();
            //CreateMap<List<BookGenre>, List<BookGenreViewModel>>();

            CreateMap<User, UserViewModel>();
            //CreateMap<List<User>, List<UserViewModel>>();
        }

    }
}