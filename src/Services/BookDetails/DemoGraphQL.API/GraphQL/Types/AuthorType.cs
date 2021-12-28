using DemoGraphQL.Abstraction.Authors.Entities;
using DemoGraphQL.Abstraction.Books.Services;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGraphQL.API.GraphQL.Types
{
    public class AuthorType:ObjectType<AuthorEntity>
    {
        protected override void Configure(IObjectTypeDescriptor<AuthorEntity> descriptor)
        {
            descriptor.Field(s => s.Id).Type<IntType>();
            descriptor.Field(s => s.BookId).Type<IntType>();
            descriptor.Field("book").Resolve(async (ctx, ct) =>
            {
                return (await ctx.Service<IBookService>().GetBooks()).FirstOrDefault(a => a.Id == ctx.Parent<AuthorEntity>().BookId);
            });

        }
    }
}
