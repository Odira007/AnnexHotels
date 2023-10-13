using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnnexHotels.Data.Migrations
{
    public partial class SeededDataModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Hotels",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 10, 13, 15, 5, 24, 531, DateTimeKind.Local).AddTicks(5024), new DateTime(2023, 10, 18, 15, 5, 24, 531, DateTimeKind.Local).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 10, 13, 15, 5, 24, 531, DateTimeKind.Local).AddTicks(6634), new DateTime(2023, 10, 20, 15, 5, 24, 531, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 10, 13, 15, 5, 24, 531, DateTimeKind.Local).AddTicks(6659), new DateTime(2023, 10, 27, 15, 5, 24, 531, DateTimeKind.Local).AddTicks(6661) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 10, 13, 15, 5, 24, 531, DateTimeKind.Local).AddTicks(6663), new DateTime(2023, 10, 19, 15, 5, 24, 531, DateTimeKind.Local).AddTicks(6665) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 10, 13, 15, 5, 24, 531, DateTimeKind.Local).AddTicks(6666), new DateTime(2023, 10, 22, 15, 5, 24, 531, DateTimeKind.Local).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 13, 15, 5, 24, 527, DateTimeKind.Local).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 13, 15, 5, 24, 530, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 13, 15, 5, 24, 530, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 13, 15, 5, 24, 530, DateTimeKind.Local).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 13, 15, 5, 24, 531, DateTimeKind.Local).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 13, 15, 5, 24, 531, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 13, 15, 5, 24, 531, DateTimeKind.Local).AddTicks(3583));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 10, 9, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(6679), new DateTime(2023, 10, 14, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 10, 9, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(8281), new DateTime(2023, 10, 16, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 10, 9, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(8307), new DateTime(2023, 10, 23, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(8309) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 10, 9, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(8311), new DateTime(2023, 10, 15, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 10, 9, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(8315), new DateTime(2023, 10, 18, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 9, 16, 23, 7, 758, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 9, 16, 23, 7, 776, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 9, 16, 23, 7, 776, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 9, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 9, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 9, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 9, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(4964));
        }
    }
}
