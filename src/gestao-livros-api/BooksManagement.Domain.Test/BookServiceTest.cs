using BooksManagement.Domain.Entities;
using BooksManagement.Domain.Interfaces.IReposiories;
using BooksManagement.Domain.Interfaces.IServices;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace BooksManagement.Domain.Test
{
    public class BookServiceTest
    {
        
        [Fact]
        public async Task Create_Book_Test()
        {
            //Arrange
            var bookService = new Mock<IBookService>();
            var bookRepository = new Mock<IBookRepository>();
            var author = new Author("Lucas Gabriel");

            var book = new Book("A volta dos que não foram", DateTime.Now, string.Empty, 35, 5, 1);
            book.SetAuthor(author);
            bookRepository.Setup(pr => pr.Add(It.IsAny<Book>())).Returns(book);

            //Act
            var createResult = await bookService.Object.Create(book);

            //Assert
            bookRepository.Verify(pr => pr.Add(It.IsAny<Book>()), Times.Once);
            Assert.NotNull(createResult);
            Assert.Equal(book.Status, createResult.Status);
            Assert.Equal(book.Title, createResult.Title);
            Assert.Equal(book.AuthorId, createResult.AuthorId);

        }
    }
}
