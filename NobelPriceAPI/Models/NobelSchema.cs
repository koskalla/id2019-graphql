using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;

namespace NobelPriceAPI.Models
{
    public class NobelSchema : Schema
    {
        public NobelSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<NobelQuery>();
        }
    }
}
