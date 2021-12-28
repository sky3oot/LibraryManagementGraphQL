using DemoGraphQL.Abstraction.Authors.Services;
using DemoGraphQL.Abstraction.Books.Entities;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGraphQL.API.GraphQL.Types
{
    public class BookType: ObjectType<BookEntity>
    {
        protected override void Configure(IObjectTypeDescriptor<BookEntity> descriptor)
        {
            descriptor.Field(s => s.Id).Type<IntType>();
            descriptor.Field(s => s.AuthorId).Type<IntType>();
            descriptor.Field("author").Resolve(async (ctx, ct) =>
            {
                return (await ctx.Service<IAuthorService>().GetAuthor()).FirstOrDefault(a => a.Id == ctx.Parent<BookEntity>().AuthorId);
            });

        }

        }
    }
