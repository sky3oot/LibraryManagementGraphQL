
using DemoGraphQLTest.Abstraction.BookLoan.Model;
using DemoGraphQLTest.Abstraction.BookLoan.Repository;
using DemoGraphQLTest.Abstraction.BookLoan.Service;
using DemoGraphQLTest.Abstraction.BookReader.Model;
using DemoGraphQLTest.Abstraction.BookReader.Repository;
using DemoGraphQLTest.Abstraction.BookReader.Service;
using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGraphQLTest.API.GraphQL
{
    public class Mutation
    {
        private readonly ILoanService _loanService;
        private readonly IReaderService _readerService;
        public Mutation(ILoanService loanService,IReaderService readerService)
        {
            _loanService = loanService;
            _readerService = readerService;
        }
        public async Task<Loan> AddLoan([Service] ILoanRepository repository, int id, int bookId,  int readerId)
        {
            //RequestContext context = SecurityContextHelper.GetCurrentRequestContext(Request.HttpContext.User);
            var loan = new Loan()
            {
                Id = id,
                BookId = bookId,
                ReaderId = readerId
             
            };

            var lon = await _loanService.AddLoan(loan);

            return loan;




        }

        public async Task<Reader> AddReader([Service] IReaderRepository repository, int readerId, string readerName, int loanId,string readerAddress)
        {
            //RequestContext context = SecurityContextHelper.GetCurrentRequestContext(Request.HttpContext.User);
            var reader = new Reader()
            {
                ReaderId = readerId,
                ReaderName = readerName,
                ReaderAddress = readerAddress,
                LoanId = loanId,
           
            };

            var ar = await _readerService.AddReader(reader);

            return reader;




        }

        public async Task<Loan> UpdateLoan([Service] ILoanRepository repository, int id, int bookId, int readerId )
        {
            
            var loan = new Loan()
            {
                Id = id,
                BookId = bookId,
                ReaderId = readerId
             

            };
     
            await _loanService.UpdateLoan(loan);

            return loan;




        }

        public async Task DeleteLoan([Service] ILoanRepository repository, int id)
        {
            
          

            var commandResult = await _loanService.DeleteLoan(id);









        }


        public async Task<Reader> UpdateReader([Service] IReaderRepository repository, int readerId, string readerName, int loanId, string readerAddress)
        {

            var reader = new Reader()
            {
         ReaderId = readerId,
         ReaderName = readerName,
         LoanId = loanId,
         ReaderAddress = readerAddress
               
            

            };

            await _readerService.UpdateReader(reader);

            return reader;




        }

        public async Task DeleteReader([Service] IReaderRepository repository, int id)
        {



            var commandResult = await _readerService.DeleteReader(id);









        }

    }
}
