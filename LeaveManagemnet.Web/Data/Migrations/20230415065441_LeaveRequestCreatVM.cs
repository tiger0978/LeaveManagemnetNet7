using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagemnet.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class LeaveRequestCreatVM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a0208cd-e6f9-4400-8606-c8d6771bcb63",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ea496aa-5859-47c6-a732-722beddc5329", "AQAAAAIAAYagAAAAEKi1n5u3C+ZQ3ZKTLOkJaaUdYZ+8TEVc0Qlf1TvLd5dG1hHvlxkQ9eRLhOtw+1n80w==", "ed2536ea-27b6-4ddd-a58a-ab684fc08c40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dbb1d2e-acbd-4c9c-8d93-d020c48a8431",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ab3487e-52bd-4bf1-a403-17f96c0f3214", "AQAAAAIAAYagAAAAEHr4DujLV9ouHAukO9Zs/OEPpukVirCElUGTs/Z3ymMsglLBMjMPx3gssbr5JrrBcQ==", "c65e3761-811d-4139-8816-0062f524d117" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a0208cd-e6f9-4400-8606-c8d6771bcb63",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a18c879c-f359-4835-9f35-b7b2577ea0f8", "AQAAAAIAAYagAAAAEJzWl8L/wN0Gj/mPmfj7ItRI830A153OzlT4A8WVHyaaK7ibxKeplQrcIg7O7FlS5g==", "3ceab5f8-3836-4a83-a9bd-2657920ba901" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dbb1d2e-acbd-4c9c-8d93-d020c48a8431",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e5a94fb-c75d-445b-9b33-cafe1889b239", "AQAAAAIAAYagAAAAEOFmIcsTIwC0kPRtdyQKlrxWftUNq2Da9gfMDUIEK8mU2QFH4w7IjKnR5W2oF15fhw==", "6f4579fe-7034-4a1a-8b16-b8e6cfab525a" });
        }
    }
}
