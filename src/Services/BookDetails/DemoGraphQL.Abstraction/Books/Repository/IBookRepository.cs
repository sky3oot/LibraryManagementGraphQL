
using DemoGraphQL.Abstraction.Books.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGraphQL.Abstraction.Books.Repository
{
  public  interface IBookRepository:IRepository<BookEntity,int>
    {
    }
}
