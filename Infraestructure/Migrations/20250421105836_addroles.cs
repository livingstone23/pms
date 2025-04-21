using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class addroles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "48395B9B-4F2A-4E8C-8D3B-0A1E5F7B9C6D", null, "Admin", "ADMIN" },
                    { "A4F5E8B2-3C6D-4E8C-8D3B-0A1E5F7B9C6D", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-4b0f1a2c3d7e",
                columns: new[] { "ConcurrencyStamp", "IsDeleted", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0733e2e5-9745-487c-9486-ff556815b000", false, "AQAAAAIAAYagAAAAEC7uWUVNy+KeN2Wv089sKeGGlhTQe4Bi810DD8GDDtW40z9XhSiS4CtKYl3srkzD8w==", "7bd3f853-1f67-43e7-ba02-df69ae858cd8" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "48395B9B-4F2A-4E8C-8D3B-0A1E5F7B9C6D", "62f94fe7-0580-42df-969c-4b0f1a2c3d7e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A4F5E8B2-3C6D-4E8C-8D3B-0A1E5F7B9C6D");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "48395B9B-4F2A-4E8C-8D3B-0A1E5F7B9C6D", "62f94fe7-0580-42df-969c-4b0f1a2c3d7e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48395B9B-4F2A-4E8C-8D3B-0A1E5F7B9C6D");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetUsers");

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
    }
}
