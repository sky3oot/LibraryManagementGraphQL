
using DemoGraphQLTest.Abstraction.BookLoan.Service;
using DemoGraphQLTest.Abstraction.BookReader.Entities;
using DemoGraphQLTest.Abstraction.BookReader.Service;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGraphQLTest.API.GraphQL.Types
{
    public class ReaderType: ObjectType<ReaderEntity>
    {
        protected override void Configure(IObjectTypeDescriptor<ReaderEntity> descriptor)
        {
            descriptor.Field(s => s.Id).Type<IntType>();
            descriptor.Field(s => s.ReaderId).Type<IntType>();
            descriptor.Field("author").Resolve(async (ctx, ct) =>
            {
                return (await ctx.Service<ILoanService>().GetLoans()).FirstOrDefault(a => a.Id == ctx.Parent<ReaderEntity>().ReaderId);
            });

        }

        }
    }
