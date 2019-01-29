using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NobelPriceData.Models;
using Microsoft.EntityFrameworkCore;

namespace NobelPriceRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NobelWinnersController : ControllerBase
    {
        private readonly NobelDataContext _db;

        public NobelWinnersController(NobelDataContext db)
        {
            _db = db;
        }

        // GET: api/NobelWinners
        [HttpGet]
        public async Task<List<NobelWinners>> Get()
        {
            return await _db.NobelWinners.ToListAsync();

            //return new string[] { "value1", "value2" };
        }

        //// GET: api/NobelWinners/5
        [HttpGet("{name}", Name = "GetWinnersByName")]
        public async Task<List<NobelWinners>> Get(string name)
        {
            return await _db.NobelWinners.Where(x => x.Surname == name).ToListAsync();
        }

        // POST: api/NobelWinners
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/NobelWinners/5
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
