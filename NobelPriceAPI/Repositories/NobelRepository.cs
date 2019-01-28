using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NobelPriceData.Models;
using Microsoft.EntityFrameworkCore;

namespace NobelPriceAPI.Repositories
{
    public class NobelRepository : INobelRepository
    {
        private readonly NobelDataContext _db;

        public NobelRepository(NobelDataContext db)
        {
            _db = db;
        }

        public async Task<List<NobelWinners>> GetAllWinners()
        {
            return await _db.NobelWinners.ToListAsync();
        }

        public async Task<List<NobelPrizes>> GetAllPrices()
        {
            return await _db.NobelPrizes.ToListAsync();
        }
    }
}
