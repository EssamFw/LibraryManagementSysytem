using BusinessLayer.DTOs.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Tranactions
{
    public interface ITranactionService
    {
        //        Task AddLibrarian(AddLibrarianDTO librarianDTO);
        Task AddTransaction(AddTransactionDTO transactionDTO);
    }
}
