using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class Conversation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-4b0f1a2c3d7e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "989ba927-3be9-40f9-a4b4-9d9a1b3f101e", "AQAAAAIAAYagAAAAEGoMpeqni1aUdEB2/e0qT9Xydf0+KukFpN8O6sM+yufBsKI8qxMq3oS+TqeuJqH1UA==", "9afd863e-e059-42ba-af60-a4d96eaf7b70" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5019), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5027), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5034), new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5032), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5040), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5039) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5044), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5043) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5051), new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5049), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5055), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5054) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5059), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 9,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5065), new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5063), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 10,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5069), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 11,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5073), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 12,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5079), new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5078), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5076) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 13,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5083), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 14,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5088), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 15,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5094), new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5092), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 16,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5098), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 17,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5102), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5101) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 18,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5108), new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5106), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 19,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5112), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5111) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 20,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5251), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5249) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 21,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5258), new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5256), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 22,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5263), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 23,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5267), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 24,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5274), new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5272), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 25,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5278), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5276) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 26,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5282), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 27,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5288), new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5286), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 28,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5292), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 29,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5296), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5295) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 30,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5302), new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5300), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5299) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 31,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5306), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5305) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 32,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5310), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 33,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5317), new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5315), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 34,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5321), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 35,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5325), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 36,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5331), new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5329), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 37,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5335), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 38,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5339), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 39,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5345), new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5343), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 40,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5349), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 41,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5353), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 42,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5360), new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5358), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 43,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5364), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5363) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 44,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5369), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 45,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5375), new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5373), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 46,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5379), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5377) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 47,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5383), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 48,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5389), new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5387), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 49,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5393), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 50,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5397), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 51,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5401), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 52,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5407), new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5405), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5404) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 53,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5411), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 54,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5438), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 55,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5445), new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5443), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 56,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5449), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 57,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5453), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5451) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 58,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5459), new DateTime(2025, 4, 28, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5457), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 59,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5463), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5462) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 60,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5467), new DateTime(2025, 4, 27, 17, 37, 52, 220, DateTimeKind.Local).AddTicks(5466) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-4b0f1a2c3d7e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0733e2e5-9745-487c-9486-ff556815b000", "AQAAAAIAAYagAAAAEC7uWUVNy+KeN2Wv089sKeGGlhTQe4Bi810DD8GDDtW40z9XhSiS4CtKYl3srkzD8w==", "7bd3f853-1f67-43e7-ba02-df69ae858cd8" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3856), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 24, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3863), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3870), new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3867), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3866) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3876), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 24, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3880), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3879) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3886), new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3884), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3891), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 24, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3895), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 9,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3901), new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3899), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3898) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 10,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3905), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 11,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 24, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3909), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3908) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 12,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3915), new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3913), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3912) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 13,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3919), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3918) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 14,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 24, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3923), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3922) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 15,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3929), new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3927), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 16,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3934), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3932) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 17,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 24, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3938), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3936) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 18,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3944), new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3942), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 19,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3947), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3946) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 20,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 24, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3952), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 21,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3958), new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3956), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3954) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 22,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3961), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 23,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 24, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3965), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 24,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3971), new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3969), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3968) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 25,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3976), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3974) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 26,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 24, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3980), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3978) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 27,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3986), new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3984), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 28,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4023), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4021) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 29,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 24, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4028), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4026) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 30,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4034), new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4032), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 31,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4038), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 32,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 24, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4042), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 33,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4048), new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4046), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4044) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 34,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4052), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 35,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 24, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4056), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4055) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 36,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4062), new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4060), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4059) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 37,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4066), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 38,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 24, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4070), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4069) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 39,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4076), new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4074), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4073) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 40,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4080), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 41,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 24, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4083), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 42,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4089), new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4088), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 43,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4094), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 44,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 24, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4098), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 45,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4104), new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4102), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4101) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 46,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4108), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4106) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 47,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 24, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4112), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 48,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4118), new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4116), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4115) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 49,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4122), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 50,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 24, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4126), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 51,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 24, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4130), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4128) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 52,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4136), new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4134), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 53,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4140), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4138) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 54,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 24, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4144), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 55,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4149), new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4148), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 56,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4153), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 57,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 24, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4157), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 58,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4164), new DateTime(2025, 4, 22, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4161), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 59,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4167), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 60,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 24, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4171), new DateTime(2025, 4, 21, 12, 58, 35, 454, DateTimeKind.Local).AddTicks(4170) });
        }
    }
}
