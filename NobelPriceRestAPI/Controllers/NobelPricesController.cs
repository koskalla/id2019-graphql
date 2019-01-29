using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NobelPriceData.Models;

namespace NobelPriceRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NobelPricesController : ControllerBase
    {

        private readonly NobelDataContext _db;

        public NobelPricesController(NobelDataContext db)
        {
            _db = db;
        }


        // GET api/values
        [HttpGet]
        public async Task<List<NobelPrizes>> Get()
        {
            return await _db.NobelPrizes.ToListAsync();
        }

        // GET: api/NobelPrices/5
        [HttpGet("{year}", Name = "GetPricesByYear")]
        public async Task<List<NobelPrizes>> Get(string year)
        {
            return await _db.NobelPrizes.Where(x => x.Year.ToString() == year).ToListAsync();
        }

        // POST: api/NobelPrices
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/NobelPrices/5
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
