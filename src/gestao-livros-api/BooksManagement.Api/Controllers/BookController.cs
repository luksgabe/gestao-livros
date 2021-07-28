using System;
using System.Threading.Tasks;
using BooksManagement.App.Interfaces;
using BooksManagement.Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BooksManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookApp _bookApp;


        public BookController(IBookApp bookApp)
        {
            _bookApp = bookApp;
        }

        // GET: api/Book
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _bookApp.GetBooks());
        }

        // GET: api/Book/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            return Ok(await _bookApp.GetBook(id));
        }

        // POST: api/Book
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BookDto book)
        {
            try
            {
                await _bookApp.Create(book);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Book/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
