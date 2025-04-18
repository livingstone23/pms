using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class updateAttachmentFileSize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "Attachments",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-4b0f1a2c3d7e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e4d8f95-9516-479e-b433-643af1416b25", "AQAAAAIAAYagAAAAENl9f5OdnZ7DNZQkJ/QmzJDbMIn4IN9TtMZtjVfktpNNruPpaoUVFOWrQlDfjRbd2Q==", "6226ea8a-1f73-4b46-89ba-0825e83d81ad" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2150), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2104) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2158), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2164), new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2162), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2170), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2175), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2181), new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2179), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2185), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2189), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 9,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2195), new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2193), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 10,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2199), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 11,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2298), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 12,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2305), new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2303), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 13,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2309), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2307) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 14,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2314), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2313) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 15,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2376), new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2318), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 16,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2381), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 17,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2385), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 18,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2391), new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2389), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2388) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 19,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2395), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 20,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2399), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 21,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2404), new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2403), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 22,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2409), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 23,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2415), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 24,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2421), new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2419), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 25,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2425), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 26,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2429), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 27,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2434), new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2433), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2431) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 28,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2438), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 29,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2442), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2441) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 30,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2448), new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2446), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 31,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2452), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 32,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2457), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2455) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 33,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2462), new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2461), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2459) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 34,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2466), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2465) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 35,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2470), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2469) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 36,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2476), new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2474), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 37,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2480), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 38,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2484), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 39,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2489), new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2488), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 40,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2493), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 41,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2498), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 42,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2504), new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2502), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2501) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 43,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2508), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2506) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 44,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2512), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 45,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2550), new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2548), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 46,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2554), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 47,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2558), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 48,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2564), new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2562), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2561) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 49,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2568), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 50,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2572), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 51,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2577), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 52,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2583), new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2581), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2580) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 53,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2587), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2585) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 54,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2591), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2589) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 55,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2596), new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2595), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 56,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2600), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 57,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2604), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2603) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 58,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2610), new DateTime(2025, 4, 19, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2608), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 59,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2614), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 60,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2618), new DateTime(2025, 4, 18, 14, 13, 52, 536, DateTimeKind.Local).AddTicks(2617) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "Attachments",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-4b0f1a2c3d7e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24014c0c-04fc-48a2-bf84-2227abc1f9bd", "AQAAAAIAAYagAAAAEDIYerstHdTH97X6ZhuEOfBxt1jrJlXFBcEAeVsRP+S+y/5pLVza5hCpjc0IHSz4WQ==", "27b30204-8575-43ce-98d0-000d0c151b57" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4415), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4422), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4421) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4429), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4427), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4425) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4435), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4439), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4445), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4443), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4450), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4454), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 9,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4460), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4458), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4457) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 10,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4464), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4463) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 11,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4468), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 12,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4474), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4472), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 13,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4479), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 14,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4483), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 15,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4489), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4487), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 16,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4493), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 17,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4497), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4495) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 18,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4503), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4501), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 19,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4507), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 20,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4511), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 21,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4517), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4515), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4514) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 22,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4522), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 23,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4526), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 24,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4532), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4530), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4528) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 25,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4535), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4534) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 26,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4539), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 27,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4546), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4544), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4543) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 28,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4550), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4548) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 29,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4554), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4553) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 30,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4560), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4558), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 31,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4564), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 32,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4567), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 33,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4573), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4572), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 34,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4607), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 35,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4612), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 36,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4618), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4616), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 37,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4622), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 38,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4626), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 39,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4632), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4630), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4629) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 40,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4636), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4634) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 41,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4640), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 42,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4646), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4644), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 43,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4650), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 44,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4654), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 45,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4660), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4658), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 46,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4665), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 47,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4669), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 48,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4676), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4674), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 49,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4679), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 50,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4683), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 51,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4687), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 52,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4693), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4691), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 53,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4697), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 54,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4701), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 55,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4707), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4705), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4704) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 56,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4710), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4709) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 57,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4714), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4713) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 58,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4720), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4718), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4717) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 59,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4724), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 60,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4728), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4726) });
        }
    }
}
