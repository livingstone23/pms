using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class addCloseByInTicket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpectedDate",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClosedBy",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClosedDate",
                table: "Tickets",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Tickets",
                type: "datetime2",
                nullable: true);

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
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(525), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(534), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(540), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(544), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(548), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(553), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(557), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(562), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 9,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(566), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(564) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 10,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(570), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 11,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(574), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(573) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 12,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(579), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 13,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(583), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(582) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 14,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(587), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 15,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(592), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 16,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(596), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(594) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 17,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(600), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 18,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(670), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 19,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(675), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(673) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 20,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(679), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(677) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 21,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(683), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 22,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(687), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(685) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 23,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(691), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 24,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(695), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 25,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(699), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 26,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(704), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(702) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 27,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(708), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(706) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 28,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(712), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 29,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(717), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 30,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(721), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(720) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 31,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(725), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 32,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(729), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(728) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 33,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(733), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(732) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 34,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(737), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(736) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 35,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(742), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(740) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 36,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(746), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(744) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 37,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(750), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 38,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(754), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(753) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 39,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(759), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(757) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 40,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(763), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(762) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 41,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(767), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 42,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(771), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 43,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(775), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 44,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(779), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(778) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 45,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(784), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(782) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 46,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(788), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 47,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(792), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 48,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 16, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(796), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(795) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 49,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 22, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(801), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(799) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 50,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2025, 4, 18, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(805), null, new DateTime(2025, 4, 15, 12, 34, 32, 798, DateTimeKind.Local).AddTicks(803) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClosedBy",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ClosedDate",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "LastUpdateDate",
                table: "Tickets");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpectedDate",
                table: "Tickets",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-4b0f1a2c3d7e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0b11176-9b14-4237-941f-ed6a8cb8e538", "AQAAAAIAAYagAAAAEBUcmlRc65SsOpk+WU2BVpLa1KiKBPuAU0BWimYfnV/qiPjdGDOfH2PyfU08vVJjjQ==", "1bb6df77-849f-4aa7-9404-80e61f4f914b" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9754), new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 14, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9764), new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 12, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9769), new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9773), new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9772) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 14, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9778), new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 12, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9782), new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9781) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9786), new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9785) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 14, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9792), new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 9,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 12, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9796), new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 10,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9801), new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 11,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 14, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9806), new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 12,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 12, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9810), new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 13,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9815), new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 14,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 14, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9819), new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 15,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 12, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9824), new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9822) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 16,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9828), new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 17,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 14, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9832), new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9831) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 18,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 12, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9837), new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9836) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 19,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9842), new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 20,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 14, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9847), new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 21,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 12, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9852), new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 22,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9856), new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 23,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 14, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9861), new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 24,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 12, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9866), new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 25,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9870), new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 26,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 14, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9874), new DateTime(2025, 4, 11, 23, 56, 40, 247, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 27,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 12, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(3), new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 28,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(8), new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 29,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 14, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(12), new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 30,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 12, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(17), new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 31,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(22), new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 32,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 14, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(27), new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 33,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 12, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(32), new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 34,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(37), new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(36) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 35,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 14, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(42), new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 36,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 12, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(48), new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(46) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 37,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(53), new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(51) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 38,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 14, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(58), new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 39,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 12, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(63), new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 40,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(68), new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 41,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 14, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(73), new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 42,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 12, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(78), new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 43,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(83), new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 44,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 14, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(87), new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(85) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 45,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 12, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(91), new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 46,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(96), new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 47,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 14, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(101), new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 48,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 12, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(106), new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(104) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 49,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 18, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(110), new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(108) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 50,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2025, 4, 14, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(114), new DateTime(2025, 4, 11, 23, 56, 40, 248, DateTimeKind.Local).AddTicks(113) });
        }
    }
}
