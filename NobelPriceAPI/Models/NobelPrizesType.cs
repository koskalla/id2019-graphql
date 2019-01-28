using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NobelPriceData.Models;
using GraphQL.Types;
using NobelPriceAPI.Repositories;


namespace NobelPriceAPI.Models
{
    public class NobelPrizesType : ObjectGraphType<NobelPrizes>
    {
        public NobelPrizesType(INobelRepository nobelRepository)
        {
            Field<IntGraphType>("Id", resolve: context => context.Source.Id);
            Field<FloatGraphType>("Year", resolve: context => context.Source.Year);
            Field(x => x.Category);
            Field(x => x.Motivation);
            Field(x => x.City);
            Field(x => x.Country);
            Field<ListGraphType<NobelWinnersType>>("NobelWinners",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "Id" }),
                resolve: context => nobelRepository.GetWinnersById(context.Source.Id));
        }
    }
}
