using System;
using System.Collections.Generic;
using BooksManagement.Domain.Enuns;

namespace BooksManagement.Domain.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; private set; }

        public long AuthorId { get; private set; }

        public virtual Author Author { get; private set; }

        public virtual ICollection<BookGenre> BookGenres { get; private set; }

        public Book(string title, long authorId)
        {
            Title = title;
            AuthorId = authorId;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            Status = Status.Active;
        }

        public Book(long id, string title, long authorId, Status status, DateTime created_At)
        {
            Id = id;
            Title = title;
            AuthorId = authorId;
            Status = status;
            CreatedAt = created_At;
            UpdatedAt = DateTime.Now;
        }

        public void SetAuthor(Author author)
        {
            Author = author;
        }

        public void SetBookGenres(List<BookGenre> bookGenres)
        {
            BookGenres = bookGenres;
        }

    }
}
