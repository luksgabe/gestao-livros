using AutoMapper;
using BooksManagement.App.ViewModels;
using BooksManagement.Domain.Entities;
using System.Collections.Generic;

namespace BooksManagement.App.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<AuthorViewModel, Author>()
                .ConstructUsing(p => new Author(p.Id, p.Name, p.Status, p.CreatedAt));
            //CreateMap<List<AuthorViewModel>, List<Author>>();

            CreateMap<BookViewModel, Book>()
                .ConstructUsing(p => new Book(p.Id, p.Title, p.PublicationDate, p.Synopsis, p.PriceAverage, p.Classification, p.AuthorId, p.Status, p.CreatedAt));
            //CreateMap<List<BookViewModel>, List<Book>>();

            CreateMap<GenreViewModel, Genre>()
                .ConstructUsing(p => new Genre(p.Id, p.Name, p.Status, p.CreatedAt, p.UpdatedAt));
            //CreateMap<List<GenreViewModel>, List<Genre>>();

            CreateMap<BookGenreViewModel, BookGenre>()
                .ConstructUsing(p => new BookGenre(p.BookId, p.GenreId));
            //CreateMap<List<BookGenreViewModel>, List<BookGenre>>();

            CreateMap<UserViewModel, User>()
                .ConstructUsing(p => new User(p.Id, p.Name, p.LastName, p.Email, p.Password, p.Status, p.CreatedAt));
            //CreateMap<List<UserViewModel>, List<User>>();
        }
    }
}