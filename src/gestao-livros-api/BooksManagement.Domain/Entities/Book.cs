using System;
using System.Collections.Generic;
using BooksManagement.Domain.Enuns;

namespace BooksManagement.Domain.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; private set; }

        public long AuthorId { get; private set; }

        public DateTime PublicationDate { get; private set; }

        public string Synopsis { get; private set; }

        public decimal PriceAverage { get; private set; }

        public decimal Classification { get; private set; }

        public virtual Author Author { get; private set; }

        public virtual ICollection<BookGenre> BookGenres { get; private set; }

        public Book(string title, DateTime publicationDate, string synopsis, decimal priceAverage, decimal classification, long authorId)
        {
            Title = title;
            PublicationDate = publicationDate;
            Synopsis = synopsis;
            PriceAverage = priceAverage;
            Classification = classification;
            AuthorId = authorId;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            Status = Status.Active;
        }

        public Book(long id, string title, DateTime publicationDate, string synopsis, decimal priceAverage, decimal classification, long authorId, Status status, DateTime created_At)
        {
            Id = id;
            Title = title;
            PublicationDate = publicationDate;
            Synopsis = synopsis;
            PriceAverage = priceAverage;
            Classification = classification;
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
