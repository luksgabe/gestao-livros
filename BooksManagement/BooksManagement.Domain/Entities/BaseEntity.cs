using BooksManagement.Domain.Enuns;
using System;

namespace BooksManagement.Domain.Entities
{
    public abstract class BaseEntity
    {
        public virtual long Id { get; set; }
        public virtual DateTime CreatedAt { get; set; }
        public virtual DateTime UpdatedAt { get; set; }
        public Status Status { get; set; }
    }
}
