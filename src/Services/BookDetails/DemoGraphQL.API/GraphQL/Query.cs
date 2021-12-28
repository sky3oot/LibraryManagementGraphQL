using DemoGraphQL.Abstraction.Authors.Models;
using DemoGraphQL.Abstraction.Authors.Services;
using DemoGraphQL.Abstraction.Books.Entities;
using DemoGraphQL.Abstraction.Books.Models;
using DemoGraphQL.Abstraction.Books.Services;
using HotChocolate;
using HotChocolate.Resolvers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGraphQL.API.GraphQL
{
    public class Query
    {
        public Task<IEnumerable<Book>> GetBooksAsync(IResolverContext ctx) => ctx.Service<IBookService>().GetBooks();



        public async Task<Book> GetBookAsync([Service] IBookService _service, int id)
        {
            var book = await _service.GetBook(id) ;
            return book;
        }

        public Task<IEnumerable<Author>> GetAuthorsAsync(IResolverContext ctx) => ctx.Service<IAuthorService>().GetAuthor();


        public async Task<Author> GetAuthorAsync([Service] IAuthorService _service, int id)
        {
            var author = await _service.GetAuthor(id);
            return author;
        }


    }
}
