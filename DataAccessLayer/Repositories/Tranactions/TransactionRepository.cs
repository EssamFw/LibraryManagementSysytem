using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DataAccessLayer.Repositories.Tranactions
{
    public class TransactionRepository
    {
        //private readonly LibraryContext _context;

        //public TransactionRepository(LibraryContext context)
        //{
        //    _context = context;
        //}

        //public async Task<List<Transaction>> GetAllTransactionsAsync()
        //{
        //    return await _context.Transactions.Include(t => t.Librarian).Include(t => t.Member).ToListAsync();
        //}

        //public async Task<Transaction> GetTransactionByIdAsync(int id)
        //{
        //    return await _context.Transactions.Include(t => t.Librarian).Include(t => t.Member)
        //        .FirstOrDefaultAsync(t => t.TransactionID == id);
        //}

        //public async Task AddTransactionAsync(Transaction transaction)
        //{
        //    _context.Transactions.Add(transaction);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task UpdateTransactionAsync(Transaction transaction)
        //{
        //    _context.Transactions.Update(transaction);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task DeleteTransactionAsync(int id)
        //{
        //    var transaction = await _context.Transactions.FindAsync(id);
        //    if (transaction != null)
        //    {
        //        _context.Transactions.Remove(transaction);
        //        await _context.SaveChangesAsync();
        //    }
        //}
    }
}
