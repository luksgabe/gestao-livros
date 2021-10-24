using BooksManagement.Domain.Enuns;
using System;

namespace BooksManagement.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        public User(string name, string lastName, string email, string password)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            Password = password;
            Status = Enuns.Status.Active;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public User(long id, string name, string lastName, string email, string password, Status status, DateTime createdAt)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Email = email;
            Password = password;
            Status = status;
            CreatedAt = createdAt;
            UpdatedAt = DateTime.Now;
        }
    }
}
