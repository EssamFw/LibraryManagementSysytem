using DataAccessLayer.Entities;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace DataAccessLayer.context
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>

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
            modelBuilder.ApplyConfigurationsFromAssembly
                (
                typeof(ApplicationDbContext).Assembly);
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
                     new Librarian {ID=3,First_Name="Mohammed",Last_Name="Ali",Email="MohammedAli@gmail.com",Phone="01011224706"},
                     new Librarian {ID=4,First_Name="Adel",Last_Name="Ahmed",Email="Adel@gmail.com",Phone="01011228888"}
                );
            modelBuilder.Entity<Book>().HasData(
            new Book() { ID = 1, Amount = 5, Author = "Amir Amr", Daily_Rent = 5, Genre = "Romance", Image = "1.jpeg", Status = "Available", Title = "جبارة العشق", LibrarianID_FK = 1 },
                new Book() { ID = 2, Amount = 4, Author = "Jeen Osten", Daily_Rent = 5, Genre = "Romance", Image = "2.jpeg", Status = "Available", Title = "كبرياء وهوا", LibrarianID_FK = 2 },
                new Book() { ID = 3, Amount = 3, Author = "Mona Elmarshood", Daily_Rent = 5, Genre = "Romance", Image = "3.jpeg", Status = "Available", Title = "أنت لي", LibrarianID_FK = 3 },
                new Book() { ID = 4, Amount = 2, Author = "Mwafaq Elsnoosy", Daily_Rent = 5, Genre = "Romance", Image = "4.jpeg", Status = "Available", Title = "أحببتك أنت", LibrarianID_FK = 4 },
                new Book() { ID = 5, Amount = 4, Author = "Khawla Hamdy", Daily_Rent = 5, Genre = "Romance", Image = "5.jpeg", Status = "Available", Title = "في قلبي أنثى عبرية", LibrarianID_FK = 1 },
                new Book() { ID = 6, Amount = 3, Author = "Galal Amin", Daily_Rent = 5, Genre = "Biography", Image = "6.jpeg", Status = "Available", Title = "ماذا علمتني الحياه", LibrarianID_FK = 4 },
                new Book() { ID = 7, Amount = 1, Author = "Mostafa Zahran", Daily_Rent = 5, Genre = "Biography", Image = "7.jpeg", Status = "Available", Title = "بطولات من التاريخ", LibrarianID_FK = 3 },
                new Book() { ID = 8, Amount = 5, Author = "Abdalla Saleh", Daily_Rent = 5, Genre = "Biography", Image = "8.jpeg", Status = "Available", Title = "عظماء بلا مدارس", LibrarianID_FK = 1 },
                new Book() { ID = 9, Amount = 4, Author = "Tarek Elbashry", Daily_Rent = 5, Genre = "Biography", Image = "9.jpeg", Status = "Available", Title = "شخصيات تاريخية", LibrarianID_FK = 3 },
                new Book() { ID = 10, Amount = 3, Author = "Ibrahim Ahmed", Daily_Rent = 5, Genre = "Biography", Image = "10.jpeg", Status = "Available", Title = "بنوالأزرق", LibrarianID_FK = 1 },
                new Book() { ID = 11, Amount = 5, Author = "Peter Swanson", Daily_Rent = 5, Genre = "Crime", Image = "11.jpeg", Status = "Available", Title = "ثماني جرائم كاملة", LibrarianID_FK = 1 },
                new Book() { ID = 12, Amount = 4, Author = "’Mahmoud Wahba", Daily_Rent = 5, Genre = "Crime", Image = "12.jpeg", Status = "Available", Title = "جريمة في بيت المتولي", LibrarianID_FK = 3 },
                new Book() { ID = 13, Amount = 3, Author = "Noran Khaled", Daily_Rent = 5, Genre = "Crime", Image = "13.jpeg", Status = "Available", Title = "طرد يصل متأخرا", LibrarianID_FK = 1 },
                new Book() { ID = 14, Amount = 2, Author = "Khaled Amin", Daily_Rent = 5, Genre = "Crime", Image = "14.jpeg", Status = "Available", Title = "جرائم الغراب السبع", LibrarianID_FK = 2 },
                new Book() { ID = 15, Amount = 4, Author = "Noha Dawood", Daily_Rent = 5, Genre = "Crime", Image = "15.jpeg", Status = "Available", Title = "جريمة السيدةهاء", LibrarianID_FK = 1 },
                new Book() { ID = 16, Amount = 3, Author = "Carl Sagan", Daily_Rent = 5, Genre = "Since Fiction", Image = "16.jpeg", Status = "Available", Title = "اتصال", LibrarianID_FK = 4 },
                new Book() { ID = 17, Amount = 1, Author = "Arthar Conan Duel", Daily_Rent = 5, Genre = "Since Fiction", Image = "17.jpeg", Status = "Available", Title = "The Lost World", LibrarianID_FK = 1 },
                new Book() { ID = 18, Amount = 5, Author = "Harbert Gorge", Daily_Rent = 5, Genre = "Since Fiction", Image = "18.jpeg", Status = "Available", Title = "The War Of The Worlds", LibrarianID_FK = 1 },
                new Book() { ID = 19, Amount = 4, Author = "Ahmed Al Hemdan", Daily_Rent = 5, Genre = "Since Fiction", Image = "19.jpeg", Status = "Available", Title = "آرسس", LibrarianID_FK = 3 },
                new Book() { ID = 20, Amount = 3, Author = "Amar Yaser", Daily_Rent = 5, Genre = "Since Fiction", Image = "20.jpeg", Status = "Available", Title = "أرض قيمورا", LibrarianID_FK = 1 },
                new Book() { ID = 21, Amount = 5, Author = "Susan Hill", Daily_Rent = 5, Genre = "Horror", Image = "21.jpeg", Status = "Available", Title = "The Small Hand", LibrarianID_FK = 1 },
                new Book() { ID = 22, Amount = 4, Author = "Khaled Amin", Daily_Rent = 5, Genre = "Horror", Image = "22.jpeg", Status = "Available", Title = "انهم يأتون ليلا", LibrarianID_FK = 3 },
                new Book() { ID = 23, Amount = 3, Author = "Ayman Ayady", Daily_Rent = 5, Genre = "Horror", Image = "23.jpeg", Status = "Available", Title = "النكرومانسيرا", LibrarianID_FK = 1 },
                new Book() { ID = 24, Amount = 2, Author = "Amr Elmnofy", Daily_Rent = 5, Genre = "Horror", Image = "24.jpeg", Status = "Available", Title = "بئر برهوت", LibrarianID_FK = 2 },
                new Book() { ID = 25, Amount = 4, Author = "Khaled Amin", Daily_Rent = 5, Genre = "Horror", Image = "25.jpeg", Status = "Available", Title = "زائر منتصف الليل", LibrarianID_FK = 1 },
                new Book() { ID = 26, Amount = 3, Author = "Radwa Ashour", Daily_Rent = 5, Genre = "History", Image = "26.jpeg", Status = "Available", Title = "ثلاثية غرناطة", LibrarianID_FK = 4 },
                new Book() { ID = 27, Amount = 1, Author = "Reem Basiony", Daily_Rent = 5, Genre = "History", Image = "27.jpeg", Status = "Available", Title = "أولاد الناس", LibrarianID_FK = 1 },
                new Book() { ID = 28, Amount = 5, Author = "Amir Arslan", Daily_Rent = 5, Genre = "History", Image = "28.jpeg", Status = "Available", Title = "أسرار القصور", LibrarianID_FK = 1 },
                new Book() { ID = 29, Amount = 4, Author = "Mahmoud Taher", Daily_Rent = 5, Genre = "History", Image = "29.jpeg", Status = "Available", Title = "وداعا طليطلة", LibrarianID_FK = 3 },
                new Book() { ID = 30, Amount = 3, Author = "Amr Afifi", Daily_Rent = 5, Genre = "History", Image = "30.jpeg", Status = "Available", Title = "فاندلاسيا", LibrarianID_FK = 1 }
                );
            //modelBuilder.Entity<Member>().HasData(


            //    );

            /*
             public static List<Book> BookData()
        {
            return new List<Book>()
            {

            };
             */




            base.OnModelCreating(modelBuilder);


        }
        

        /*
         
         */



        //=====================================================================

    }

}

