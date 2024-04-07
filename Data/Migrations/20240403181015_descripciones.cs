using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeatroBack.Data.Migrations
{
    /// <inheritdoc />
    public partial class descripciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Obras",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Hehequeloco");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Hehequeloco");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Hehequeloco");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Hehequeloco");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Hehequeloco");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Hehequeloco");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Hehequeloco");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Hehequeloco");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Hehequeloco");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Hehequeloco");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Obras");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 29, 17, 35, 55, 797, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 29, 17, 35, 55, 797, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 29, 17, 35, 55, 797, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 29, 17, 35, 55, 797, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 29, 17, 35, 55, 797, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 29, 17, 35, 55, 797, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 29, 17, 35, 55, 797, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 29, 17, 35, 55, 797, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 29, 17, 35, 55, 797, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 3, 29, 17, 35, 55, 797, DateTimeKind.Local).AddTicks(5368));
        }
    }
}
