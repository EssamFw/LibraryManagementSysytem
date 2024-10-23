using BusinessLayer.DTOs.Transactions;
using DataAccessLayer.Repositories.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DataAccessLayer.Entities;

namespace BusinessLayer.Services.Tranactions
{
    public class TranactionService : ITranactionService
    {
        /*
                 private readonly ILibrarianRepository _librarianRepository;
        public LibrarianService(ILibrarianRepository liprarianarepository)
        {
            _librarianRepository = liprarianarepository;
        }
         */
        private readonly ITransactionRepository _transactionRepository1;
        public TranactionService(ITransactionRepository transactionRepository)
        {

            _transactionRepository1 = transactionRepository;
        }
        public async Task AddTransaction(AddTransactionDTO transactionDTO)
        {

            TransactionB transaction = transactionDTO.ToTransaction();
            _transactionRepository1.Add(transaction);
            _transactionRepository1.SaveChanges();

        }
    }
}
