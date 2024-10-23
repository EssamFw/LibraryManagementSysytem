using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Transactions
{
    public interface ITransactionRepository
    {
        Task Add(TransactionB transaction);
        Task SaveChanges();
    }
}
