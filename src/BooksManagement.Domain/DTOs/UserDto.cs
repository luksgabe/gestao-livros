using BooksManagement.Domain.Enuns;
using System;

namespace BooksManagement.Domain.DTOs
{
    public class UserDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Status Status { get; set; }
    }
}
