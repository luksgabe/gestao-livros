using BooksManagement.Domain.Enuns;
using System;
using System.Collections.Generic;

namespace BooksManagement.Domain.Entities
{
    public class Author : BaseEntity
    {
        public string Name { get; private set; }
        public virtual ICollection<Book> Books { get; private set; }

        public Author(string name)
        {
            Name = name;
            Status = Status.Active;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public Author(long id, string name, Status status, DateTime created_At)
        {
            Id = id;
            Name = name;
            Status = status;
            CreatedAt = created_At;
            UpdatedAt = DateTime.Now;
        }

        public void SetBooks(List<Book> books)
        {
            Books = books;
        }

    }
}
