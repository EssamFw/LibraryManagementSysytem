namespace DataAccessLayer.Entities
{
    public class BookTransaction
    {
        public int BookID { get; set; } // Foreign key
        public Book Book { get; set; } // Navigation property

        public int TransactionID { get; set; } // Foreign key
        public TransactionB Transaction { get; set; } // Navigation property

        public int Amount { get; set; } // Number of copies involved in the transaction

        // Composite Key: BookID + TransactionID

    }
}
