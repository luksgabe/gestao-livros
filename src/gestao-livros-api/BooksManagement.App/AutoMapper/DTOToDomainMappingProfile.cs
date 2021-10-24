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
            CreateMap<AuthorDto, Author>()
                .ConvertUsing(p => new Author(p.Id, p.Name, p.Status, p.CreatedAt));
            CreateMap<List<AuthorDto>, List<Author>>();

            CreateMap<BookDto, Book>()
                .ConvertUsing(p => new Book(p.Id, p.Title, p.AuthorId, p.Status, p.CreatedAt));
            CreateMap<List<BookDto>, List<Book>>();

            CreateMap<GenreDto, Genre>()
                .ConvertUsing(p => new Genre(p.Id, p.Name, p.Status, p.CreatedAt, p.UpdatedAt));
            CreateMap<List<GenreDto>, List<Genre>>();

            CreateMap<BookGenreDto, BookGenre>()
                .ConvertUsing(p => new BookGenre(p.BookId, p.GenreId));
            CreateMap<List<BookGenreDto>, List<BookGenre>>();

            CreateMap<UserDto, User>()
                .ConvertUsing(p => new User(p.Id, p.Name, p.LastName, p.Email, p.Password, p.Status, p.CreatedAt));
            CreateMap<List<UserDto>, List<User>>();
        }
    }
}