using AutoMapper;
using BooksManagement.Domain.DTOs;
using BooksManagement.Domain.Entities;
using System.Collections.Generic;

namespace BooksManagement.App.AutoMapper
{
    internal class DTOToDomainMappingProfile : Profile
    {
        public DTOToDomainMappingProfile()
        {
            CreateMap<AuthorDto, Author>();
            CreateMap<List<AuthorDto>, List<Author>>();

            CreateMap<BookDto, Book>();
            CreateMap<List<BookDto>, List<Book>>();

            CreateMap<GenreDto, Genre>();
            CreateMap<List<GenreDto>, List<Genre>>();

            CreateMap<BookGenreDto, BookGenre>();
            CreateMap<List<BookGenreDto>, List<BookGenre>>();

            CreateMap<UserDto, User>();
            CreateMap<List<UserDto>, List<User>>();
        }
    }
}