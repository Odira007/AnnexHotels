using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnnexHotels.Data.Migrations
{
    public partial class EntityPropertiesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookingStatus",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookingStatus", "CheckInDate", "CheckOutDate", "HotelId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 21, 10, 8, 43, 273, DateTimeKind.Local).AddTicks(7495), 1 });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookingStatus", "CheckInDate", "CheckOutDate", "HotelId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 23, 10, 8, 43, 273, DateTimeKind.Local).AddTicks(8176), 1 });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookingStatus", "CheckInDate", "CheckOutDate", "HotelId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 30, 10, 8, 43, 273, DateTimeKind.Local).AddTicks(8198), 3 });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate", "HotelId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 22, 10, 8, 43, 273, DateTimeKind.Local).AddTicks(8201), 5 });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookingStatus", "CheckInDate", "CheckOutDate", "HotelId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 25, 10, 8, 43, 273, DateTimeKind.Local).AddTicks(8204), 4 });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "BookingStatus", "CheckInDate", "CheckOutDate", "CustomerId", "HotelId" },
                values: new object[] { 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 25, 10, 8, 43, 273, DateTimeKind.Local).AddTicks(8206), 2, 2 });

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

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "BookingId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "BookingId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "BookingId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "BookingId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "BookingId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "BookingId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "BookingId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "BookingId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "BookingId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "BookingId",
                value: 6);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "BookingStatus",
                table: "Bookings");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate", "HotelId" },
                values: new object[] { new DateTime(2023, 10, 13, 15, 5, 24, 531, DateTimeKind.Local).AddTicks(5024), new DateTime(2023, 10, 18, 15, 5, 24, 531, DateTimeKind.Local).AddTicks(5949), null });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate", "HotelId" },
                values: new object[] { new DateTime(2023, 10, 13, 15, 5, 24, 531, DateTimeKind.Local).AddTicks(6634), new DateTime(2023, 10, 20, 15, 5, 24, 531, DateTimeKind.Local).AddTicks(6647), null });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate", "HotelId" },
                values: new object[] { new DateTime(2023, 10, 13, 15, 5, 24, 531, DateTimeKind.Local).AddTicks(6659), new DateTime(2023, 10, 27, 15, 5, 24, 531, DateTimeKind.Local).AddTicks(6661), null });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate", "HotelId" },
                values: new object[] { new DateTime(2023, 10, 13, 15, 5, 24, 531, DateTimeKind.Local).AddTicks(6663), new DateTime(2023, 10, 19, 15, 5, 24, 531, DateTimeKind.Local).AddTicks(6665), null });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate", "HotelId" },
                values: new object[] { new DateTime(2023, 10, 13, 15, 5, 24, 531, DateTimeKind.Local).AddTicks(6666), new DateTime(2023, 10, 22, 15, 5, 24, 531, DateTimeKind.Local).AddTicks(6669), null });

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

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "BookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "BookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "BookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "BookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "BookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "BookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "BookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "BookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "BookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "BookingId",
                value: null);
        }
    }
}
