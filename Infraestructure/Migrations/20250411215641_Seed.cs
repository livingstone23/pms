using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountConfirmed", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 0, false, null, "a0b11176-9b14-4237-941f-ed6a8cb8e538", "Test@gmail.com", true, false, null, "TEST@GMAIL.COM", "TEST@GMAIL.COM", "AQAAAAIAAYagAAAAEBUcmlRc65SsOpk+WU2BVpLa1KiKBPuAU0BWimYfnV/qiPjdGDOfH2PyfU08vVJjjQ==", null, false, "1bb6df77-849f-4aa7-9404-80e61f4f914b", false, "Test@gmail.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Application Bug" },
                    { 2, "Network Issue" },
                    { 3, "User Issue" }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "PriorityId", "ExpectedDays", "IsActive", "PriorityName" },
                values: new object[,]
                {
                    { 1, 14, true, "Low" },
                    { 2, 7, true, "Medium" },
                    { 3, 1, true, "High" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName" },
                values: new object[,]
                {
                    { 1, "Product 1" },
                    { 2, "Product 2" },
                    { 3, "Product 3" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "AssignedToId", "CategoryId", "Description", "ExpectedDate", "PriorityId", "ProductId", "RaisedBy", "RaisedDate", "Status", "Summary", "UserId" },
                values: new object[,]
                {
                    { 1, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 1, "Description 1", new DateTime(2025, 4, 18, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9754), 1, 1, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9709), "NEW", "Ticket 1", null },
                    { 2, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 2, "Description 2", new DateTime(2025, 4, 14, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9764), 2, 2, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9762), "OPEN", "Ticket 2", null },
                    { 3, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 3, "Description 3", new DateTime(2025, 4, 12, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9769), 3, 3, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9767), "CLOSED", "Ticket 3", null },
                    { 4, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 1, "Description 4", new DateTime(2025, 4, 18, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9773), 1, 1, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9772), "NEW", "Ticket 4", null },
                    { 5, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 2, "Description 5", new DateTime(2025, 4, 14, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9778), 2, 2, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9776), "OPEN", "Ticket 5", null },
                    { 6, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 3, "Description 6", new DateTime(2025, 4, 12, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9782), 3, 3, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9781), "CLOSED", "Ticket 6", null },
                    { 7, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 1, "Description 7", new DateTime(2025, 4, 18, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9786), 1, 1, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9785), "NEW", "Ticket 7", null },
                    { 8, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 2, "Description 8", new DateTime(2025, 4, 14, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9792), 2, 2, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9790), "OPEN", "Ticket 8", null },
                    { 9, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 3, "Description 9", new DateTime(2025, 4, 12, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9796), 3, 3, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9795), "CLOSED", "Ticket 9", null },
                    { 10, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 1, "Description 10", new DateTime(2025, 4, 18, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9801), 1, 1, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9799), "NEW", "Ticket 10", null },
                    { 11, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 2, "Description 11", new DateTime(2025, 4, 14, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9806), 2, 2, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9804), "OPEN", "Ticket 11", null },
                    { 12, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 3, "Description 12", new DateTime(2025, 4, 12, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9810), 3, 3, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9809), "CLOSED", "Ticket 12", null },
                    { 13, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 1, "Description 13", new DateTime(2025, 4, 18, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9815), 1, 1, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9813), "NEW", "Ticket 13", null },
                    { 14, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 2, "Description 14", new DateTime(2025, 4, 14, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9819), 2, 2, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9818), "OPEN", "Ticket 14", null },
                    { 15, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 3, "Description 15", new DateTime(2025, 4, 12, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9824), 3, 3, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9822), "CLOSED", "Ticket 15", null },
                    { 16, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 1, "Description 16", new DateTime(2025, 4, 18, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9828), 1, 1, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9827), "NEW", "Ticket 16", null },
                    { 17, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 2, "Description 17", new DateTime(2025, 4, 14, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9832), 2, 2, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9831), "OPEN", "Ticket 17", null },
                    { 18, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 3, "Description 18", new DateTime(2025, 4, 12, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9837), 3, 3, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9836), "CLOSED", "Ticket 18", null },
                    { 19, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 1, "Description 19", new DateTime(2025, 4, 18, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9842), 1, 1, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9840), "NEW", "Ticket 19", null },
                    { 20, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 2, "Description 20", new DateTime(2025, 4, 14, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9847), 2, 2, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9845), "OPEN", "Ticket 20", null },
                    { 21, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 3, "Description 21", new DateTime(2025, 4, 12, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9852), 3, 3, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9850), "CLOSED", "Ticket 21", null },
                    { 22, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 1, "Description 22", new DateTime(2025, 4, 18, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9856), 1, 1, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9855), "NEW", "Ticket 22", null },
                    { 23, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 2, "Description 23", new DateTime(2025, 4, 14, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9861), 2, 2, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9860), "OPEN", "Ticket 23", null },
                    { 24, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 3, "Description 24", new DateTime(2025, 4, 12, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9866), 3, 3, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9864), "CLOSED", "Ticket 24", null },
                    { 25, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 1, "Description 25", new DateTime(2025, 4, 18, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9870), 1, 1, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9869), "NEW", "Ticket 25", null },
                    { 26, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 2, "Description 26", new DateTime(2025, 4, 14, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9874), 2, 2, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9873), "OPEN", "Ticket 26", null },
                    { 27, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 3, "Description 27", new DateTime(2025, 4, 12, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(3), 3, 3, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(1), "CLOSED", "Ticket 27", null },
                    { 28, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 1, "Description 28", new DateTime(2025, 4, 18, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(8), 1, 1, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(7), "NEW", "Ticket 28", null },
                    { 29, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 2, "Description 29", new DateTime(2025, 4, 14, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(12), 2, 2, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(11), "OPEN", "Ticket 29", null },
                    { 30, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 3, "Description 30", new DateTime(2025, 4, 12, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(17), 3, 3, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(16), "CLOSED", "Ticket 30", null },
                    { 31, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 1, "Description 31", new DateTime(2025, 4, 18, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(22), 1, 1, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(21), "NEW", "Ticket 31", null },
                    { 32, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 2, "Description 32", new DateTime(2025, 4, 14, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(27), 2, 2, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(25), "OPEN", "Ticket 32", null },
                    { 33, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 3, "Description 33", new DateTime(2025, 4, 12, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(32), 3, 3, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(31), "CLOSED", "Ticket 33", null },
                    { 34, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 1, "Description 34", new DateTime(2025, 4, 18, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(37), 1, 1, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(36), "NEW", "Ticket 34", null },
                    { 35, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 2, "Description 35", new DateTime(2025, 4, 14, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(42), 2, 2, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(41), "OPEN", "Ticket 35", null },
                    { 36, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 3, "Description 36", new DateTime(2025, 4, 12, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(48), 3, 3, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(46), "CLOSED", "Ticket 36", null },
                    { 37, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 1, "Description 37", new DateTime(2025, 4, 18, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(53), 1, 1, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(51), "NEW", "Ticket 37", null },
                    { 38, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 2, "Description 38", new DateTime(2025, 4, 14, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(58), 2, 2, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(56), "OPEN", "Ticket 38", null },
                    { 39, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 3, "Description 39", new DateTime(2025, 4, 12, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(63), 3, 3, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(61), "CLOSED", "Ticket 39", null },
                    { 40, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 1, "Description 40", new DateTime(2025, 4, 18, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(68), 1, 1, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(66), "NEW", "Ticket 40", null },
                    { 41, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 2, "Description 41", new DateTime(2025, 4, 14, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(73), 2, 2, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(71), "OPEN", "Ticket 41", null },
                    { 42, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 3, "Description 42", new DateTime(2025, 4, 12, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(78), 3, 3, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(76), "CLOSED", "Ticket 42", null },
                    { 43, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 1, "Description 43", new DateTime(2025, 4, 18, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(83), 1, 1, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(81), "NEW", "Ticket 43", null },
                    { 44, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 2, "Description 44", new DateTime(2025, 4, 14, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(87), 2, 2, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(85), "OPEN", "Ticket 44", null },
                    { 45, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 3, "Description 45", new DateTime(2025, 4, 12, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(91), 3, 3, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(90), "CLOSED", "Ticket 45", null },
                    { 46, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 1, "Description 46", new DateTime(2025, 4, 18, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(96), 1, 1, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(95), "NEW", "Ticket 46", null },
                    { 47, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 2, "Description 47", new DateTime(2025, 4, 14, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(101), 2, 2, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(100), "OPEN", "Ticket 47", null },
                    { 48, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 3, "Description 48", new DateTime(2025, 4, 12, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(106), 3, 3, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(104), "CLOSED", "Ticket 48", null },
                    { 49, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 1, "Description 49", new DateTime(2025, 4, 18, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(110), 1, 1, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(108), "NEW", "Ticket 49", null },
                    { 50, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", 2, "Description 50", new DateTime(2025, 4, 14, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(114), 2, 2, "62f94fe7-0580-42df-969c-4b0f1a2c3d7e", new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(113), "OPEN", "Ticket 50", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-4b0f1a2c3d7e");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);
        }
    }
}
