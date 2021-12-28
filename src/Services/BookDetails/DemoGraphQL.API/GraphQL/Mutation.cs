using DemoGraphQL.Abstraction.Authors.Models;
using DemoGraphQL.Abstraction.Authors.Repository;
using DemoGraphQL.Abstraction.Authors.Services;
using DemoGraphQL.Abstraction.Books.Models;
using DemoGraphQL.Abstraction.Books.Repository;
using DemoGraphQL.Abstraction.Books.Services;
using HotChocolate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGraphQL.API.GraphQL
{
    public class Mutation
    {
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;
        public Mutation(IBookService bookService,IAuthorService authorService)
        {
            _bookService = bookService;
            _authorService = authorService;
        }
        public async Task<Book> AddBook([Service] IBookRepository repository, int id, string descrition, string isnb, int authorId,string title)
        {
            //RequestContext context = SecurityContextHelper.GetCurrentRequestContext(Request.HttpContext.User);
            var book = new Book()
            {
                Id = id,
                Descrition = descrition,
            ISNB = isnb,
            Title = title,
            AuthorId = authorId
            };

            var bk = await _bookService.AddBook(book);

            return book;




        }

        public async Task<Author> AddAuthor([Service] IAuthorRepository repository, int id, string authorName, int bookId)
        {
            //RequestContext context = SecurityContextHelper.GetCurrentRequestContext(Request.HttpContext.User);
            var author = new Author()
            {
                Id = id,
                AuthorName = authorName,
                BookId = bookId,
           
            };

            var ar = await _authorService.AddAuthor(author);

            return author;




        }

        public async Task<Book> UpdateBook([Service] IBookRepository repository, int id, string descrition, string isnb, int authorId, string title)
        {
            
            var book = new Book()
            {
                Id = id,
                Descrition = descrition,
                ISNB = isnb,
                AuthorId = authorId,
                Title = title,
             

            };
     
            await _bookService.UpdateBook(book);

            return book;




        }

        public async Task DeleteBook([Service] IBookRepository repository, int id)
        {
            
          

            var commandResult = await _bookService.DeleteBook(id);









        }


        public async Task<Author> UpdateAuthor([Service] IAuthorRepository repository, int id, string authorName, int bookId)
        {

            var author = new Author()
            {
                Id = id,
               
                AuthorName = authorName,
                BookId = bookId


            };

            await _authorService.UpdateAuthor(author);

            return author;




        }

        public async Task DeleteAuthor([Service] IAuthorRepository repository, int id)
        {



            var commandResult = await _authorService.DeleteAuthor(id);









        }

    }
}
