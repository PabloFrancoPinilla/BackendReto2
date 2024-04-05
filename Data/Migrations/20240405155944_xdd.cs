using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeatroBack.Data.Migrations
{
    /// <inheritdoc />
    public partial class xdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 12, 17, 59, 44, 398, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 4, 12, 17, 59, 44, 398, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 4, 12, 17, 59, 44, 398, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 4, 12, 17, 59, 44, 398, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 4, 12, 17, 59, 44, 398, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 4, 12, 17, 59, 44, 398, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 4, 12, 17, 59, 44, 398, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 4, 12, 17, 59, 44, 398, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 4, 12, 17, 59, 44, 398, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 4, 12, 17, 59, 44, 398, DateTimeKind.Local).AddTicks(3000));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 10, 20, 10, 14, 852, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 4, 10, 20, 10, 14, 852, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 4, 10, 20, 10, 14, 852, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 4, 10, 20, 10, 14, 852, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 4, 10, 20, 10, 14, 852, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 4, 10, 20, 10, 14, 852, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 4, 10, 20, 10, 14, 852, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 4, 10, 20, 10, 14, 852, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 4, 10, 20, 10, 14, 852, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 4, 10, 20, 10, 14, 852, DateTimeKind.Local).AddTicks(4665));
        }
    }
}
