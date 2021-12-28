
using DemoGraphQLTest.Abstraction.BookReader.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGraphQLTest.Abstraction.BookReader.Repository
{
public    interface IReaderRepository:  IRepository<ReaderEntity, int>
    {
    }
}
