using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksManagement.App.Interfaces;
using BooksManagement.Domain.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {

        private readonly IGenreApp _genreApp;

        public GenreController(IGenreApp genreApp)
        {
            _genreApp = genreApp;
        }

        // GET: api/Genre
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _genreApp.GetGenres().ConfigureAwait(true));
        }

        // GET: api/Genre/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Genre
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GenreDto genre)
        {
            try
            {
                await _genreApp.Create(genre);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Genre/5
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
