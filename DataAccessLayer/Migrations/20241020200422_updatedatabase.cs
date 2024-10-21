using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class updatedatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "Amount", "Author", "Daily_Rent", "Genre", "Image", "LibrarianID_FK", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 5, "Amir Amr", 5m, "Romance", "1.jpeg", 1, "Available", "جبارة العشق" },
                    { 2, 4, "Jeen Osten", 5m, "Romance", "2.jpeg", 2, "Available", "كبرياء وهوا" },
                    { 3, 3, "Mona Elmarshood", 5m, "Romance", "3.jpeg", 3, "Available", "أنت لي" },
                    { 5, 4, "Khawla Hamdy", 5m, "Romance", "5.jpeg", 1, "Available", "في قلبي أنثى عبرية" },
                    { 7, 1, "Mostafa Zahran", 5m, "Biography", "7.jpeg", 3, "Available", "بطولات من التاريخ" },
                    { 8, 5, "Abdalla Saleh", 5m, "Biography", "8.jpeg", 1, "Available", "عظماء بلا مدارس" },
                    { 9, 4, "Tarek Elbashry", 5m, "Biography", "9.jpeg", 3, "Available", "شخصيات تاريخية" },
                    { 10, 3, "Ibrahim Ahmed", 5m, "Biography", "10.jpeg", 1, "Available", "بنوالأزرق" },
                    { 11, 5, "Peter Swanson", 5m, "Crime", "11.jpeg", 1, "Available", "ثماني جرائم كاملة" },
                    { 12, 4, "’Mahmoud Wahba", 5m, "Crime", "12.jpeg", 3, "Available", "جريمة في بيت المتولي" },
                    { 13, 3, "Noran Khaled", 5m, "Crime", "13.jpeg", 1, "Available", "طرد يصل متأخرا" },
                    { 14, 2, "Khaled Amin", 5m, "Crime", "14.jpeg", 2, "Available", "جرائم الغراب السبع" },
                    { 15, 4, "Noha Dawood", 5m, "Crime", "15.jpeg", 1, "Available", "جريمة السيدةهاء" },
                    { 17, 1, "Arthar Conan Duel", 5m, "Since Fiction", "17.jpeg", 1, "Available", "The Lost World" },
                    { 18, 5, "Harbert Gorge", 5m, "Since Fiction", "18.jpeg", 1, "Available", "The War Of The Worlds" },
                    { 19, 4, "Ahmed Al Hemdan", 5m, "Since Fiction", "19.jpeg", 3, "Available", "آرسس" },
                    { 20, 3, "Amar Yaser", 5m, "Since Fiction", "20.jpeg", 1, "Available", "أرض قيمورا" },
                    { 21, 5, "Susan Hill", 5m, "Horror", "21.jpeg", 1, "Available", "The Small Hand" },
                    { 22, 4, "Khaled Amin", 5m, "Horror", "22.jpeg", 3, "Available", "انهم يأتون ليلا" },
                    { 23, 3, "Ayman Ayady", 5m, "Horror", "23.jpeg", 1, "Available", "النكرومانسيرا" },
                    { 24, 2, "Amr Elmnofy", 5m, "Horror", "24.jpeg", 2, "Available", "بئر برهوت" },
                    { 25, 4, "Khaled Amin", 5m, "Horror", "25.jpeg", 1, "Available", "زائر منتصف الليل" },
                    { 27, 1, "Reem Basiony", 5m, "History", "27.jpeg", 1, "Available", "أولاد الناس" },
                    { 28, 5, "Amir Arslan", 5m, "History", "28.jpeg", 1, "Available", "أسرار القصور" },
                    { 29, 4, "Mahmoud Taher", 5m, "History", "29.jpeg", 3, "Available", "وداعا طليطلة" },
                    { 30, 3, "Amr Afifi", 5m, "History", "30.jpeg", 1, "Available", "فاندلاسيا" }
                });

            migrationBuilder.InsertData(
                table: "Librarians",
                columns: new[] { "ID", "Email", "First_Name", "Last_Name", "Phone" },
                values: new object[] { 4, "Adel@gmail.com", "Adel", "Ahmed", "01011228888" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "Amount", "Author", "Daily_Rent", "Genre", "Image", "LibrarianID_FK", "Status", "Title" },
                values: new object[,]
                {
                    { 4, 2, "Mwafaq Elsnoosy", 5m, "Romance", "4.jpeg", 4, "Available", "أحببتك أنت" },
                    { 6, 3, "Galal Amin", 5m, "Biography", "6.jpeg", 4, "Available", "ماذا علمتني الحياه" },
                    { 16, 3, "Carl Sagan", 5m, "Since Fiction", "16.jpeg", 4, "Available", "اتصال" },
                    { 26, 3, "Radwa Ashour", 5m, "History", "26.jpeg", 4, "Available", "ثلاثية غرناطة" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Librarians",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
