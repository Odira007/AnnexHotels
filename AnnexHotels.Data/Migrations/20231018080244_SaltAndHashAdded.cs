using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnnexHotels.Data.Migrations
{
    public partial class SaltAndHashAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Salt",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaltHashedPassword",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CheckOutDate",
                value: new DateTime(2023, 10, 23, 9, 2, 42, 250, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CheckOutDate",
                value: new DateTime(2023, 10, 25, 9, 2, 42, 251, DateTimeKind.Local).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CheckOutDate",
                value: new DateTime(2023, 11, 1, 9, 2, 42, 251, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CheckOutDate",
                value: new DateTime(2023, 10, 24, 9, 2, 42, 251, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CheckOutDate",
                value: new DateTime(2023, 10, 27, 9, 2, 42, 251, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CheckOutDate",
                value: new DateTime(2023, 10, 27, 9, 2, 42, 251, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 18, 9, 2, 42, 217, DateTimeKind.Local).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 18, 9, 2, 42, 249, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 18, 9, 2, 42, 249, DateTimeKind.Local).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 18, 9, 2, 42, 250, DateTimeKind.Local).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 18, 9, 2, 42, 250, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 18, 9, 2, 42, 250, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 18, 9, 2, 42, 250, DateTimeKind.Local).AddTicks(5096));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salt",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SaltHashedPassword",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CheckOutDate",
                value: new DateTime(2023, 10, 21, 10, 8, 43, 273, DateTimeKind.Local).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CheckOutDate",
                value: new DateTime(2023, 10, 23, 10, 8, 43, 273, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CheckOutDate",
                value: new DateTime(2023, 10, 30, 10, 8, 43, 273, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CheckOutDate",
                value: new DateTime(2023, 10, 22, 10, 8, 43, 273, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CheckOutDate",
                value: new DateTime(2023, 10, 25, 10, 8, 43, 273, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CheckOutDate",
                value: new DateTime(2023, 10, 25, 10, 8, 43, 273, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 16, 10, 8, 43, 270, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 16, 10, 8, 43, 272, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 16, 10, 8, 43, 272, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 16, 10, 8, 43, 272, DateTimeKind.Local).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 16, 10, 8, 43, 273, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 16, 10, 8, 43, 273, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 16, 10, 8, 43, 273, DateTimeKind.Local).AddTicks(4002));
        }
    }
}
