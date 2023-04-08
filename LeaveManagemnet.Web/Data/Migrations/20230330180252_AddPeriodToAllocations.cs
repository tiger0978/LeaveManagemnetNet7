using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagemnet.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPeriodToAllocations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a0208cd-e6f9-4400-8606-c8d6771bcb63",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ad1fe55-983c-497e-b85b-31facfb25e7a", "AQAAAAIAAYagAAAAEOMNAtSvt+ZBlw6nM8llGvf2+qNg165AKvFB5vxD/7vyrsSsROgyMV6y6I1AaCJHLg==", "9ce486bc-d301-4006-9b8b-329493759278" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dbb1d2e-acbd-4c9c-8d93-d020c48a8431",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9f0afa8-3ea1-4d90-89fb-368ff42b1e63", "AQAAAAIAAYagAAAAEEfXpf8fd+EgwIKCwkM8XuL/ToBKC8iyiE66aTDPKZHdSytqL0LU3+XKoOklocWHGQ==", "32743b10-af47-4255-abb6-f51a348caa82" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a0208cd-e6f9-4400-8606-c8d6771bcb63",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48c1e273-0038-4d50-8839-348fdbf31ea5", "AQAAAAIAAYagAAAAEBL2JybiRfsuY0rKgbvp1ENjpKMzK08afpZoi+mLixgHIi+oonOmG5in8JNe8VJwQw==", "f47173a1-5393-45bc-98ff-f06f51d123d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dbb1d2e-acbd-4c9c-8d93-d020c48a8431",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99bb2ef1-d3f2-4aa6-a790-7d03a729c2d2", "AQAAAAIAAYagAAAAEDpqR58iBXrwFLPJdIooy8sPQZF+yehUOWeULYlQR5IUpnOiiJSimrmvvJysA7uwKw==", "9375f5c5-dccc-4ffc-8626-99a87e710228" });
        }
    }
}
