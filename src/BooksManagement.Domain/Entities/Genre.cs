using BooksManagement.Domain.Enuns;
using System;
using System.Collections.Generic;

namespace BooksManagement.Domain.Entities
{
    public class Genre : BaseEntity
    {
        public string Name { get; private set; }
        public virtual ICollection<BookGenre> BookGenres { get; private set; }


        public Genre(string name)
        {
            Name = name;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public Genre(long id, string name, Status status, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            Name = name;
            Status = status;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public void SetBookGenres(List<BookGenre> bookGenres)
        {
            BookGenres = bookGenres;
        }
    }
}
