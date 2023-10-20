using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnnexHotels.Data.Migrations
{
    public partial class CustomerTableModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Customers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "ConfirmPassword",
                table: "Customers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CheckOutDate",
                value: new DateTime(2023, 10, 24, 11, 43, 14, 904, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CheckOutDate",
                value: new DateTime(2023, 10, 26, 11, 43, 14, 904, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CheckOutDate",
                value: new DateTime(2023, 11, 2, 11, 43, 14, 904, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CheckOutDate",
                value: new DateTime(2023, 10, 25, 11, 43, 14, 904, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CheckOutDate",
                value: new DateTime(2023, 10, 28, 11, 43, 14, 904, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CheckOutDate",
                value: new DateTime(2023, 10, 28, 11, 43, 14, 904, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 19, 11, 43, 14, 898, DateTimeKind.Local).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 19, 11, 43, 14, 899, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 19, 11, 43, 14, 899, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 19, 11, 43, 14, 903, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 19, 11, 43, 14, 903, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 19, 11, 43, 14, 903, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 19, 11, 43, 14, 903, DateTimeKind.Local).AddTicks(9721));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Customers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ConfirmPassword",
                table: "Customers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

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
    }
}
