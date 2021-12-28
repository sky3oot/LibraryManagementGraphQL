
using DemoGraphQL.Abstraction.Books.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGraphQL.Abstraction.Books.Models
{
   public class Book
    {
        public Book()
        {

        }
        public Book(BookEntity entity)
        {
            this.Title = entity.Title;
            this.Descrition = entity.Descrition;
            this.ISNB = entity.ISNB;
            this.AuthorId = entity.AuthorId;
            this.Id = entity.Id;
        }
        public  string Title { get; set; }
        public string Descrition { get; set; }

        public string ISNB { get; set; }
        public int AuthorId { get; set; }
        public int Id { get; set; }
    }
}
