﻿using System;
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

        //public async Task<List<NobelWinners>> GetAllWinners()
        //{
        //    return await _db.NobelWinners.ToListAsync();
        //}

        public async Task<List<NobelWinners>> GetWinnersById(int id)
        {
            return await _db.NobelWinners.Where(x => x.Id == id).ToListAsync();
        }

        public async Task<List<NobelWinners>> GetWinners(string name = null)
        {
            if (!string.IsNullOrEmpty(name))
            {
                return await _db.NobelWinners.Where(x => x.Surname == name).ToListAsync();
            }
            return await _db.NobelWinners.ToListAsync();
        }

        //public async Task<List<NobelPrizes>> GetAllPrices()
        //{
        //    return await _db.NobelPrizes.ToListAsync();
        //}

        public async Task<List<NobelPrizes>> GetPricesById(int id)
        {
            return await _db.NobelPrizes.Where(x => x.Id == id).ToListAsync();
        }

        public async Task<List<NobelPrizes>> GetPrices(string category = null, string year = null)
        {
            if (!string.IsNullOrEmpty(year) && !string.IsNullOrEmpty(category))
            {
                return await _db.NobelPrizes.Where(x => x.Year.ToString() == year && x.Category == category).ToListAsync();
            }
            if (!string.IsNullOrEmpty(year))
            {
                return await _db.NobelPrizes.Where(x => x.Year.ToString() == year).ToListAsync();
            }
            if (!string.IsNullOrEmpty(category))
            {
                return await _db.NobelPrizes.Where(x => x.Category == category).ToListAsync();
            }
            return await _db.NobelPrizes.ToListAsync();
        }
    }
}
