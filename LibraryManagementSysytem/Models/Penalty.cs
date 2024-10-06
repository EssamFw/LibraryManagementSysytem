using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSysytem.Models
{
    public class Penalty
    {
        public int ID { get; set; }

        public decimal Daily_Penalty { get; set; }

        public int OverDueDateDays { get; set; }

        public decimal Value { get; set; }

        [ForeignKey("Transaction")]
        public int TransactionID_FK { get; set; }
        public Transaction Transaction { get; set; }
    }

}
