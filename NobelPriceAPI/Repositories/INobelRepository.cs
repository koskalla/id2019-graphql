using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NobelPriceData.Models;

namespace NobelPriceAPI.Repositories
{
    public interface INobelRepository
    {
        //Task<List<NobelWinners>> GetAllWinners();
        Task<List<NobelWinners>> GetWinnersById(int id);
        Task<List<NobelWinners>> GetWinners(string name);

        //Task<List<NobelPrizes>> GetAllPrices();
        Task<List<NobelPrizes>> GetPricesById(int id);
        Task<List<NobelPrizes>> GetPrices(string category, string year);

    }
}
