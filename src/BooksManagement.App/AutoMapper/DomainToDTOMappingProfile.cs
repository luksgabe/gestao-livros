using AutoMapper;
using BooksManagement.Domain.DTOs;
using BooksManagement.Domain.Entities;
using System.Collections.Generic;

namespace BooksManagement.App.AutoMapper
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Author, AuthorDto>();
            CreateMap<List<Author>, List<AuthorDto>>();

            CreateMap<Book, BookDto>();
            CreateMap<List<Book>, List<BookDto>>();

            CreateMap<Genre, GenreDto>();
            CreateMap<List<Genre>, List<GenreDto>>();

            CreateMap<BookGenre, BookGenreDto>();
            CreateMap<List<BookGenre>, List<BookGenreDto>>();

            CreateMap<User, UserDto>();
            CreateMap<List<User>, List<UserDto>>();
        }

    }
}