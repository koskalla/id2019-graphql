using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using NobelPriceAPI.Repositories;

namespace NobelPriceAPI.Models
{
    public class NobelQuery : ObjectGraphType
    {
        public NobelQuery(INobelRepository nobelRepository)
        {
            Field<ListGraphType<NobelWinnersType>>(
               "NobelWinners",
               resolve: context => nobelRepository.GetAllWinners());

            Field<ListGraphType<NobelPrizesType>>(
               "NobelPrices",
               resolve: context => nobelRepository.GetAllPrices());

        }
    }
}
