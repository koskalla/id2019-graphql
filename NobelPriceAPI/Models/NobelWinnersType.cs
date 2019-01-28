using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NobelPriceData.Models;
using GraphQL.Types;


namespace NobelPriceAPI.Models
{
    public class NobelWinnersType : ObjectGraphType<NobelWinners>
    {
        public NobelWinnersType()
        {
            Field<IntGraphType>("Id", resolve: context => context.Source.Id);
            Field(x => x.Firstname);
            Field(x => x.Surname);
            Field(x => x.Born);
            Field<DateGraphType>("Year", resolve: context => context.Source.Died);
            Field(x => x.BornCity);
            Field(x => x.BornCountry);
            Field(x => x.BornCountryCode);
            Field(x => x.DiedCity);
            Field(x => x.DiedCountry);
            Field(x => x.DiedCountryCode);
            Field(x => x.Gender);
            Field<NobelPrizesType>("IdNavigation", resolve: context => context.Source.IdNavigation);
        }
    }
}
