using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class Conversation2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conversations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConversationSid = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversations", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-4b0f1a2c3d7e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "224b1acc-3245-47ad-b7b4-8f7356f7bee4", "AQAAAAIAAYagAAAAEOsYY5Hf3VgmOs+Q9cV5Z/gzK2wxgZcx231l851oZMR34m1+iMP1Rw2vuwL4ARu1JQ==", "7183a7f1-ce07-42ef-bbe9-40b0c665cf36" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5758), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5767), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5773), new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5771), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5779), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5783), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5790), new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5788), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5794), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5798), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 9,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5881), new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5879), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 10,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5885), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 11,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5889), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 12,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5895), new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5893), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 13,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5899), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 14,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5903), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 15,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5910), new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5908), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 16,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5914), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 17,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5918), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 18,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5924), new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5922), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 19,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5928), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 20,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5931), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 21,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5937), new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5935), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 22,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5941), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 23,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5945), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 24,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5952), new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5950), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 25,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5955), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5954) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 26,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5959), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 27,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5965), new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5963), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 28,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5969), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 29,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5973), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 30,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5978), new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5976), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 31,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5982), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 32,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5986), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 33,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5992), new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5991), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 34,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5996), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 35,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6000), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(5999) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 36,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6006), new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6004), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 37,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6009), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 38,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6013), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 39,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6019), new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6017), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 40,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6023), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 41,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6027), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 42,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6034), new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6032), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 43,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6074), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 44,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6078), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 45,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6084), new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6082), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 46,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6088), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6086) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 47,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6092), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 48,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6098), new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6096), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 49,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6101), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 50,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6105), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 51,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6110), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 52,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6116), new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6114), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 53,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6120), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 54,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6124), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6122) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 55,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6129), new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6128), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 56,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6133), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 57,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6137), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 58,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6143), new DateTime(2025, 4, 28, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6141), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 59,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6147), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6145) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 60,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 30, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6151), new DateTime(2025, 4, 27, 17, 40, 58, 868, DateTimeKind.Local).AddTicks(6149) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conversations");

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
    }
}
