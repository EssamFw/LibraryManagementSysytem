using LibraryManagementSysytem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;


namespace LibraryManagementSysytem.Data
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
            //=====================================================================


            public DbSet<Book> Books { get; set; }
            public DbSet<Member> Members { get; set; }
            public DbSet<Librarian> Librarians { get; set; }
            public DbSet<Transaction> Transactions { get; set; }
            public DbSet<BookTransaction> BookTransactions { get; set; }
            public DbSet<Penalty> Penalties { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookTransaction>()
                .HasKey(bt => new { bt.BookID, bt.TransactionID }); // Composite key
            modelBuilder.Entity<Transaction>()
                .Property(t => t.Total_Cost)
                .HasPrecision(18, 4);
            modelBuilder.Entity<Penalty>()
                .Property(t => t.Value)
                .HasPrecision(18, 4); 
            modelBuilder.Entity<Penalty>()
                 .Property(t => t.Daily_Penalty)
                 .HasPrecision(18, 4); 
            modelBuilder.Entity<Book>()
                 .Property(t => t.Daily_Rent)
                 .HasPrecision(18, 4);
            modelBuilder.Entity<Librarian>().HasData(
                new Librarian {ID=1,First_Name="Essam",Last_Name="Fawzy",Email="Essamfw@gmail.com",Phone="01015044706"},
                     new Librarian {ID=2,First_Name="Amr",Last_Name="ElMawrdy",Email="Amr@gmail.com",Phone= "0102 120 2971" },
                     new Librarian {ID=3,First_Name="Mohammed",Last_Name="Ali",Email="MohammedAli@gmail.com",Phone="01011224706"}
                );


            base.OnModelCreating(modelBuilder);
        }






        //=====================================================================

    }

}

