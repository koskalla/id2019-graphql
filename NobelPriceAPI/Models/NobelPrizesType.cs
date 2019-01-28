using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NobelPriceData.Models;
using GraphQL.Types;


namespace NobelPriceAPI.Models
{
    public class NobelPrizesType : ObjectGraphType<NobelPrizes>
    {
        public NobelPrizesType()
        {
            Field<IntGraphType>("Id", resolve: context => context.Source.Id);
            Field<FloatGraphType>("Year", resolve: context => context.Source.Year);
            Field(x => x.Category);
            //Field<StringGraphType>("Year", resolve: context => context.Source.Share);
            Field(x => x.Motivation);
            Field(x => x.City);
            Field(x => x.Country);
        }
    }
}
