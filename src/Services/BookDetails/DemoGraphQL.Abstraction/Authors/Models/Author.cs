
using DemoGraphQL.Abstraction.Authors.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGraphQL.Abstraction.Authors.Models
{
   public class Author
    {
        public Author()
        {

        }
        public Author(AuthorEntity entity)
        {
            this.Id = entity.Id;
            this.AuthorName = entity.AuthorName;
            this.BookId = entity.BookId;
        }
        public int Id { get; set; }
        public string AuthorName { get; set; }

        public int BookId { get; set; }
    }
}
