using DemoGraphQLTest.Abstraction.BookLoan.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGraphQLTest.Abstraction.BookLoan.Repository
{
   public interface ILoanRepository : IRepository<LoanEntity, int>
    {
    }
}
