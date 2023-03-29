using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagemnet.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultUserAndUserName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a0208cd-e6f9-4400-8606-c8d6771bcb63",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "48c1e273-0038-4d50-8839-348fdbf31ea5", true, "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEBL2JybiRfsuY0rKgbvp1ENjpKMzK08afpZoi+mLixgHIi+oonOmG5in8JNe8VJwQw==", "f47173a1-5393-45bc-98ff-f06f51d123d7", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dbb1d2e-acbd-4c9c-8d93-d020c48a8431",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "99bb2ef1-d3f2-4aa6-a790-7d03a729c2d2", true, "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEDpqR58iBXrwFLPJdIooy8sPQZF+yehUOWeULYlQR5IUpnOiiJSimrmvvJysA7uwKw==", "9375f5c5-dccc-4ffc-8626-99a87e710228", "user@localhost.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a0208cd-e6f9-4400-8606-c8d6771bcb63",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b9d9dcdb-d5f5-4468-9410-bb8e4a8e97ba", false, null, "AQAAAAIAAYagAAAAEAyonTyBqNbt+tky5Cj5pZV0ZjSplrwyEkN3Tft5ILgcisioNwHcsUBQEN4/dyBtTg==", "8834e3c2-30e4-439a-830e-9fa05744f192", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dbb1d2e-acbd-4c9c-8d93-d020c48a8431",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1e504599-abb9-4687-a7a8-696003cf4eb0", false, null, "AQAAAAIAAYagAAAAEB5QbZn9Oa7ndhlhDuzP27TpE/JUJ6N1TSABGQvRAS32hoUlOOxbYnUe7ns+ZzKIDg==", "e9e00013-1c8e-41ca-9b99-7af34781f73b", null });
        }
    }
}
