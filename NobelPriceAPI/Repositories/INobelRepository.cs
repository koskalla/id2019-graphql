using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NobelPriceData.Models;

namespace NobelPriceAPI.Repositories
{
    public interface INobelRepository
    {
        Task<List<NobelWinners>> GetAllWinners();

        Task<List<NobelPrizes>> GetAllPrices();
    }
}
