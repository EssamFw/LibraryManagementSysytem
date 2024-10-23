using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs.Transactions
{
    public class AddTransactionDTO
    {
        public int ID { get; set; }

        public decimal Total_Cost { get; set; }

        public DateTime CheckOut_Date { get; set; }

        public DateTime Due_Date { get; set; }

        public int OverDueDate_Days { get; set; }

        public DateTime? Return_Date { get; set; }

        [ForeignKey("Librarian")]
        public int LibrarianID_FK { get; set; }
        public Librarian Librarian { get; set; }

        [ForeignKey("Member")]
        public int MemberID_FK { get; set; }
        public Member Member { get; set; }

        public List<BookTransaction> BookTransaction { get; set; }
        public Book Book { get; set; }

        public TransactionB ToTransaction()
        {
            return new TransactionB
            {
                ID = ID,
                Total_Cost = Total_Cost,
                CheckOut_Date = CheckOut_Date,
                Due_Date = Due_Date,
                OverDueDate_Days = OverDueDate_Days,
                Return_Date = Return_Date,
                LibrarianID_FK = LibrarianID_FK,
                MemberID_FK = MemberID_FK,
             

            };
        }    
    }
}
