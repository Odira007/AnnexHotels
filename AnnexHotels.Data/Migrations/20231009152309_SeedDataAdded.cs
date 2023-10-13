using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnnexHotels.Data.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Rooms_RoomId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_RoomId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "CheckedIn",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Bookings",
                newName: "CheckOutDate");

            migrationBuilder.AlterColumn<int>(
                name: "RoomNumber",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookingId",
                table: "Rooms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckInDate",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "HotelId",
                table: "Bookings",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CreatedAt", "Description", "Email", "Name", "RegNum" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 9, 16, 23, 7, 758, DateTimeKind.Local).AddTicks(8950), "Crafting serenity and luxury in nature's embrace", "aplinerc@gmailcom", "Alpine Retreats Corporation", "537J4" },
                    { 2, new DateTime(2023, 10, 9, 16, 23, 7, 776, DateTimeKind.Local).AddTicks(5367), "Redefining urban hospitality with a blend of style and relaxation", "metrocomfortco@gmailcom", "Metropolitan Comfort Co.", "3B249" },
                    { 3, new DateTime(2023, 10, 9, 16, 23, 7, 776, DateTimeKind.Local).AddTicks(5409), "Your gateway to coastal elegance and relaxation", "gazagroup@gmailcom", "Gaza group", "227A6" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "ConfirmPassword", "CreatedAt", "Email", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "sarah#$34", new DateTime(2023, 10, 9, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(1602), "sarahandersen@gmail.com", "Sarah", "Andersen", "sarah#$34", "08139050760" },
                    { 2, "john#$34", new DateTime(2023, 10, 9, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(4946), "johnfreeman@gmail.com", "John", "Freeman", "john#$34", "09033672290" },
                    { 3, "chibueze#$34", new DateTime(2023, 10, 9, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(4959), "chibuezeokpara@gmail.com", "Chibueze", "Okpara", "chibueze#$34", "08140056772" },
                    { 4, "lisa#$34", new DateTime(2023, 10, 9, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(4964), "lisahendrix@gmail.com", "Lisa", "Hendrix", "lisa#$34", "08087985609" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "CustomerId", "HotelId" },
                values: new object[,]
                {
                    { 2, new DateTime(2023, 10, 9, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(8281), new DateTime(2023, 10, 16, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(8295), 1, null },
                    { 3, new DateTime(2023, 10, 9, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(8307), new DateTime(2023, 10, 23, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(8309), 2, null },
                    { 1, new DateTime(2023, 10, 9, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(6679), new DateTime(2023, 10, 14, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(7610), 3, null },
                    { 5, new DateTime(2023, 10, 9, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(8315), new DateTime(2023, 10, 18, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(8317), 3, null },
                    { 4, new DateTime(2023, 10, 9, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(8311), new DateTime(2023, 10, 15, 16, 23, 7, 777, DateTimeKind.Local).AddTicks(8313), 4, null }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "City", "CompanyId", "Country", "Description", "Name", "Status" },
                values: new object[,]
                {
                    { 2, "Eti Osa", 1, "Nigeria", "A stylish hotel in the midst of the city, blending modernity with comfort", "Oriental Hotel", 0 },
                    { 4, "Jos", 1, "Nigeria", "Step from your room to the sandy shore at this seaside paradise", "Ebano Hotel", 0 },
                    { 3, "Manchester", 2, "England", "A beautifully restored hotel showcasing timeless charm and rich heritage", "Kruizia Hotel", 1 },
                    { 5, "Birmingham", 2, "England", "A cozy lodge perched amidst majestic peaks, perfect for outdoor enthusiasts", "Eko Hotel", 0 },
                    { 1, "New York", 3, "USA", "Nestled in the heart of lush forests, this hotel offers tranquility and luxury.", "Mavens Hotel", 0 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "BookingId", "HotelId", "IsBooked", "PricePerDay", "RoomNumber", "RoomType" },
                values: new object[,]
                {
                    { 1, null, 2, true, 40000m, 23, "Suite" },
                    { 3, null, 2, false, 60000m, 37, "Suite" },
                    { 8, null, 2, true, 40000m, 90, "Villa" },
                    { 2, null, 4, true, 45000m, 403, "Penthouse" },
                    { 9, null, 4, false, 36000m, 14, "Suite" },
                    { 6, null, 3, false, 45000m, 64, "Loft" },
                    { 5, null, 5, false, 40000m, 13, "Suite" },
                    { 7, null, 5, false, 52000m, 47, "Cabana" },
                    { 4, null, 1, true, 35000m, 54, "Loft" },
                    { 10, null, 1, false, 35000m, 76, "Cabana" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_BookingId",
                table: "Rooms",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_HotelId",
                table: "Bookings",
                column: "HotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Hotels_HotelId",
                table: "Bookings",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Bookings_BookingId",
                table: "Rooms",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Hotels_HotelId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Bookings_BookingId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_BookingId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_HotelId",
                table: "Bookings");

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "CheckInDate",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "HotelId",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "CheckOutDate",
                table: "Bookings",
                newName: "CreatedAt");

            migrationBuilder.AlterColumn<string>(
                name: "RoomNumber",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "CheckedIn",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Rooms",
                type: "ntext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_RoomId",
                table: "Bookings",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Rooms_RoomId",
                table: "Bookings",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
