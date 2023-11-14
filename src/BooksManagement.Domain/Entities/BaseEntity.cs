using BooksManagement.Domain.Enuns;
using System;

namespace BooksManagement.Domain.Entities
{
    public abstract class BaseEntity
    {
        public virtual long Id { get; protected set; }
        public virtual DateTime CreatedAt { get; protected set; }
        public virtual DateTime UpdatedAt { get; protected set; }
        public Status Status { get; protected set; }


        public void SetStatus(Status status)
        {
            Status = status;
        }

        public void Update()
        {
            UpdatedAt = DateTime.Now;
        }

    }
}
