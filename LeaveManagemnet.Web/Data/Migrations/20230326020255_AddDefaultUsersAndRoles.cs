using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagemnet.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "aa0208cd-e6f9-4400-8606-c8d6771bcb63", null, "Administrator", "ADMINISTRATOR" },
                    { "bb0208cd-e6f9-4400-8606-c8d6771bcb63", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxID", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1a0208cd-e6f9-4400-8606-c8d6771bcb63", 0, "b9d9dcdb-d5f5-4468-9410-bb8e4a8e97ba", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "Systen", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAIAAYagAAAAEAyonTyBqNbt+tky5Cj5pZV0ZjSplrwyEkN3Tft5ILgcisioNwHcsUBQEN4/dyBtTg==", null, false, "8834e3c2-30e4-439a-830e-9fa05744f192", null, false, null },
                    { "5dbb1d2e-acbd-4c9c-8d93-d020c48a8431", 0, "1e504599-abb9-4687-a7a8-696003cf4eb0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "Systen", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAIAAYagAAAAEB5QbZn9Oa7ndhlhDuzP27TpE/JUJ6N1TSABGQvRAS32hoUlOOxbYnUe7ns+ZzKIDg==", null, false, "e9e00013-1c8e-41ca-9b99-7af34781f73b", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "aa0208cd-e6f9-4400-8606-c8d6771bcb63", "1a0208cd-e6f9-4400-8606-c8d6771bcb63" },
                    { "bb0208cd-e6f9-4400-8606-c8d6771bcb63", "5dbb1d2e-acbd-4c9c-8d93-d020c48a8431" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aa0208cd-e6f9-4400-8606-c8d6771bcb63", "1a0208cd-e6f9-4400-8606-c8d6771bcb63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bb0208cd-e6f9-4400-8606-c8d6771bcb63", "5dbb1d2e-acbd-4c9c-8d93-d020c48a8431" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa0208cd-e6f9-4400-8606-c8d6771bcb63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb0208cd-e6f9-4400-8606-c8d6771bcb63");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a0208cd-e6f9-4400-8606-c8d6771bcb63");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dbb1d2e-acbd-4c9c-8d93-d020c48a8431");
        }
    }
}
