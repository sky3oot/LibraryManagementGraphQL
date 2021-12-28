
using DemoGraphQLTest.Abstraction.BookLoan.Entities;
using DemoGraphQLTest.Abstraction.BookReader.Service;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGraphQLTest.API.GraphQL.Types
{
    public class LoanType:ObjectType<LoanEntity>
    {
        protected override void Configure(IObjectTypeDescriptor<LoanEntity> descriptor)
        {
            descriptor.Field(s => s.Id).Type<IntType>();
            descriptor.Field(s => s.BookId).Type<IntType>();
            descriptor.Field("book").Resolve(async (ctx, ct) =>
            {
                return (await ctx.Service<IReaderService>().GetReaders()).FirstOrDefault(a => a.ReaderId == ctx.Parent<LoanEntity>().ReaderId);
            });

        }
    }
}
