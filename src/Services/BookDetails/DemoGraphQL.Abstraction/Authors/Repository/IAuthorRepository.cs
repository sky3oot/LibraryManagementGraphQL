
using DemoGraphQL.Abstraction.Authors.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGraphQL.Abstraction.Authors.Repository
{
  public  interface IAuthorRepository:IRepository<AuthorEntity,int>
    {
    }
}
