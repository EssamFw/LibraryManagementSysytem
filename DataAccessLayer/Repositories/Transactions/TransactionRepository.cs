using DataAccessLayer.context;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Transactions
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly ApplicationDbContext _Dbcontext;
        public TransactionRepository(ApplicationDbContext DbContext)
        {
            _Dbcontext = DbContext;
        }
        public async Task Add(TransactionB transaction)
        {
           await _Dbcontext.Transactions.AddAsync(transaction);
        }

        public Task SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
