using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagemnet.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateleaveRequestDatebase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a0208cd-e6f9-4400-8606-c8d6771bcb63",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "882eea89-f1fd-47f2-8024-64bb1840528c", "AQAAAAIAAYagAAAAELjYlSXuLOmXURCcArJ+czsUxDilKf04znKnpNzawTVx1XR1URZ3Dh5QyUS3AxIHNg==", "6f554dcd-7145-44e4-889a-0bbaa2965aad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dbb1d2e-acbd-4c9c-8d93-d020c48a8431",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4a66524-75f8-4228-8ad2-0ca9530c53bb", "AQAAAAIAAYagAAAAEJyJPiAjku2AIEKGa3oi4sAvpO8enTG2tnfHHf8XH041DrVKXu4EtkW/eMzjr8TJMQ==", "59ed36ae-80fc-4e33-a658-a5a61d96d9f7" });
        }
    }
}
