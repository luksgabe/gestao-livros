using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BooksManagement.App.Interfaces;
using BooksManagement.Domain.DTOs;
using BooksManagement.Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace BooksManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorApp _authorApp;

        public AuthorController(IAuthorApp authorApp)
        {
            _authorApp = authorApp;
        }

        // GET: api/Author
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _authorApp.GetAuthors().ConfigureAwait(true));
        }

        // GET: api/Author/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Author
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AuthorDto author)
        {
            try
            {
                await _authorApp.Create(author);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Author/5
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
