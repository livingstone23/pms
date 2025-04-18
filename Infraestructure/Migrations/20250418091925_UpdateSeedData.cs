using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4429), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4427), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4425) });

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
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4445), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4443), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4442) });

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
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4460), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4458), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4457) });

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
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4474), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4472), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4471) });

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
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4489), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4487), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4486) });

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
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4503), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4501), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4500) });

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
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4517), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4515), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4514) });

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
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4532), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4530), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4528) });

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
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4546), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4544), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4543) });

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
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4560), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4558), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4556) });

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
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4573), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4572), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4570) });

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
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4618), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4616), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4615) });

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
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4632), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4630), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4629) });

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
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4646), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4644), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4642) });

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
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4660), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4658), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4657) });

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
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4676), new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4674), new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4672) });

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

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "AssignedToId", "CategoryId", "ClosedBy", "ClosedDate", "Description", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId", "RaisedBy", "RaisedDate", "Status", "Summary", "UserId" },
                values: new object[,]
                {
                    { 51, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 2, null, null, "Description 41", new DateTime(2025, 4, 21, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4687), null, 2, 2, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4686), "OPEN", "Ticket 41", null },
                    { 52, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 3, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4693), "Description 42", new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4691), null, 3, 3, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4690), "CLOSED", "Ticket 42", null },
                    { 53, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 1, null, null, "Description 43", new DateTime(2025, 4, 25, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4697), null, 1, 1, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4696), "NEW", "Ticket 43", null },
                    { 54, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 2, null, null, "Description 44", new DateTime(2025, 4, 21, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4701), null, 2, 2, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4700), "OPEN", "Ticket 44", null },
                    { 55, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 3, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4707), "Description 45", new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4705), null, 3, 3, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4704), "CLOSED", "Ticket 45", null },
                    { 56, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 1, null, null, "Description 46", new DateTime(2025, 4, 25, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4710), null, 1, 1, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4709), "NEW", "Ticket 46", null },
                    { 57, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 2, null, null, "Description 47", new DateTime(2025, 4, 21, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4714), null, 2, 2, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4713), "OPEN", "Ticket 47", null },
                    { 58, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 3, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4720), "Description 48", new DateTime(2025, 4, 19, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4718), null, 3, 3, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4717), "CLOSED", "Ticket 48", null },
                    { 59, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 1, null, null, "Description 49", new DateTime(2025, 4, 25, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4724), null, 1, 1, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4722), "NEW", "Ticket 49", null },
                    { 60, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 2, null, null, "Description 50", new DateTime(2025, 4, 21, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4728), null, 2, 2, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 18, 11, 19, 25, 296, DateTimeKind.Local).AddTicks(4726), "OPEN", "Ticket 50", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 60);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-4b0f1a2c3d7e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b62de35-64e6-4271-af44-ce3136591333", "AQAAAAIAAYagAAAAEBaANYWnuluNzcrsfqUTrnWeMg/jBZjUI0zwKVhFvZt0ADYI7Yy/R239M16ROBYnNw==", "1272ba39-3cbb-4bd7-b692-3d9f0b164638" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(525), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(534), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(540), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(544), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(548), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(553), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(557), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(562), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 9,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(566), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(564) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 10,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(570), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 11,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(574), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(573) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 12,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(579), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 13,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(583), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(582) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 14,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(587), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 15,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(592), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 16,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(596), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(594) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 17,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(600), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 18,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(670), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 19,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(675), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(673) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 20,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(679), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(677) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 21,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(683), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 22,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(687), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(685) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 23,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(691), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 24,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(695), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 25,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(699), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 26,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(704), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(702) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 27,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(708), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(706) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 28,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(712), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 29,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(717), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 30,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(721), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(720) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 31,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(725), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 32,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(729), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(728) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 33,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(733), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(732) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 34,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(737), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(736) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 35,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(742), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(740) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 36,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(746), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(744) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 37,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(750), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 38,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(754), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(753) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 39,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(759), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(757) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 40,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(763), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(762) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 41,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(767), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 42,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(771), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 43,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(775), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 44,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(779), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(778) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 45,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(784), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(782) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 46,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(788), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 47,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(792), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 48,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(796), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(795) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 49,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(801), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(799) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 50,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(805), new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(803) });
        }
    }
}
