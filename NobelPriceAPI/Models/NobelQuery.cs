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
            //Field<ListGraphType<NobelWinnersType>>(
            //   "NobelWinners",
            //   resolve: context => nobelRepository.GetAllWinners());

            //Field<ListGraphType<NobelWinnersType>>(
            //   "NobelWinnersById",
            //   arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "Id" }),
            //   resolve: context => nobelRepository.GetWinnersById(context.GetArgument<int>("id")));

            Field<ListGraphType<NobelWinnersType>>(
               "NobelWinners",
               arguments: new QueryArguments(new QueryArgument<StringGraphType> { Name = "Name" }),
               resolve: context => nobelRepository.GetWinnersByName(context.GetArgument<string>("name")));

            //Field<ListGraphType<NobelPrizesType>>(
            //   "NobelPrices",
            //   resolve: context => nobelRepository.GetAllPrices());

            //Field<ListGraphType<NobelPrizesType>>(
            //   "NobelPricesById",
            //   arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "Id" }),
            //   resolve: context => nobelRepository.GetPricesById(context.GetArgument<int>("id")));

            Field<ListGraphType<NobelPrizesType>>(
               "NobelPrices",
               arguments: new QueryArguments(new QueryArgument<StringGraphType> { Name = "Year" }),
               resolve: context => nobelRepository.GetPricesByYear(context.GetArgument<string>("year")));
        }
    }
}
