using BooksManagement.Domain.Entities;
using BooksManagement.Domain.Interfaces.IReposiories;
using BooksManagement.Domain.Interfaces.IServices;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace BooksManagement.Domain.Test
{
    
    public class AuthorServiceTest
    {
        [Fact]
        public async Task Create_Author_Test()
        {
            //Arrange
            var authorService = new Mock<IAuthorService>();
            var authorRepository = new Mock<IAuthorRepository>();
            var author = new Author("Lucas Gabriel");

            authorRepository.Setup(pr => pr.AddAsync(It.IsAny<Author>())).Returns(Task.FromResult(author));


            //Act
            var authorResult = await authorRepository.Object.AddAsync(author);

            //Assert
            authorRepository.Verify(pr => pr.AddAsync(It.IsAny<Author>()), Times.Once);
            Assert.NotNull(authorResult);
            Assert.Equal(author.Name, authorResult.Name);
        }
    }
}
