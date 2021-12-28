
using DemoGraphQLTest.Abstraction.BookLoan.Model;
using DemoGraphQLTest.Abstraction.BookLoan.Service;
using DemoGraphQLTest.Abstraction.BookReader.Model;
using DemoGraphQLTest.Abstraction.BookReader.Service;
using HotChocolate;
using HotChocolate.Resolvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGraphQLTest.API.GraphQL
{
    public class Query
    {
        public Task<IEnumerable<Loan>> GetBookLoansAsync(IResolverContext ctx) => ctx.Service<ILoanService>().GetLoans();

        public async Task<Loan> GetBookLoanAsync([Service] ILoanService _service, int id)
        {
            var  loan = await _service.GetLoan(id) ;
            return loan;
        }

        public Task<IEnumerable<Reader>> GetBookReadersAsync(IResolverContext ctx) => ctx.Service<IReaderService>().GetReaders();


        public async Task<Reader> GetBookReaderAsync([Service] IReaderService _service, int id)
        {
            var reader = await _service.GetReader(id);
            return reader;
        }


    }
}
