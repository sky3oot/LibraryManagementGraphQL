using DemoGraphQL.Abstraction.Authors.Entities;
using DemoGraphQL.Abstraction.Authors.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGraphQL.Core.Authors.Aggregste
{
    public class AuthorAggregate : BaseAggregate<AuthorEntity>
    {
        public AuthorAggregate(AuthorEntity entity) : base(entity)
        {

        }

        public void SaveAuthor(Author author)
        {
            SetEntity(author);
        }

        public void DeleteAuthor()
        {
            Entity.IsDeleted = true;
        }

        public void ValidateAuthor(Author author)
        {

        }

        private void SetEntity(Author author)
        {
            Entity.Id = author.Id;
            Entity.AuthorName = author.AuthorName;
            Entity.BookId = author.BookId;

        }
    }
}
