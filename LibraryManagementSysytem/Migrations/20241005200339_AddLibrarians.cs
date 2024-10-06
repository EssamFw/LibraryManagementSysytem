using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Demo01.Migrations
{
    /// <inheritdoc />
    public partial class AddLibrarians : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Librarians",
                columns: new[] { "ID", "Email", "First_Name", "Last_Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Essamfw@gmail.com", "Essam", "Fawzy", "01015044706" },
                    { 2, "Amr@gmail.com", "Amr", "ElMawrdy", "0102 120 2971" },
                    { 3, "MohammedAli@gmail.com", "Mohammed", "Ali", "01011224706" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Librarians",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Librarians",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Librarians",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
