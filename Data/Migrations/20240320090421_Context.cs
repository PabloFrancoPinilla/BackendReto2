using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeatroBack.Data.Migrations
{
    /// <inheritdoc />
    public partial class Context : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Obras",
                columns: new[] { "Id", "Duration", "Genre", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "2 horas", "Misterio", "faro.jpg", "El misterio del faro" },
                    { 2, "1 hora y 30 minutos", "Fantasía", "princesa.jpg", "La princesa perdida" },
                    { 3, "2 horas y 15 minutos", "Aventura", "pirata.jpg", "El tesoro del pirata" },
                    { 4, "2 horas", "Suspenso", "mansión.jpg", "La mansión encantada" },
                    { 5, "1 hora y 45 minutos", "Drama", "circo.jpg", "El circo de los sueños" },
                    { 6, "2 horas y 30 minutos", "Aventura", "montaña.jpg", "El secreto de la montaña" },
                    { 7, "2 horas", "Misterio", "isla.jpg", "La isla misteriosa" },
                    { 8, "1 hora y 30 minutos", "Romance", "principe.jpg", "El príncipe y la doncella" },
                    { 9, "2 horas y 15 minutos", "Fantasía", "caballero.jpg", "La leyenda del caballero" },
                    { 10, "2 horas", "Suspenso", "casa.jpg", "La casa de los secretos" }
                });

            migrationBuilder.InsertData(
                table: "Salas",
                columns: new[] { "Id", "Numero", "SessionId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Number", "SalaId", "State", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1, "Available", null },
                    { 2, 2, 1, "Available", null },
                    { 3, 3, 1, "Available", null },
                    { 4, 4, 1, "Available", null },
                    { 5, 5, 1, "Available", null },
                    { 6, 6, 1, "Available", null },
                    { 7, 7, 1, "Available", null },
                    { 8, 8, 1, "Available", null },
                    { 9, 9, 1, "Available", null },
                    { 10, 10, 1, "Available", null },
                    { 11, 11, 1, "Available", null },
                    { 12, 12, 1, "Available", null },
                    { 13, 13, 1, "Available", null },
                    { 14, 14, 1, "Available", null },
                    { 15, 15, 1, "Available", null },
                    { 16, 16, 1, "Available", null },
                    { 17, 17, 1, "Available", null },
                    { 18, 18, 1, "Available", null },
                    { 19, 19, 1, "Available", null },
                    { 20, 20, 1, "Available", null },
                    { 21, 21, 1, "Available", null },
                    { 22, 22, 1, "Available", null },
                    { 23, 23, 1, "Available", null },
                    { 24, 24, 1, "Available", null },
                    { 25, 25, 1, "Available", null },
                    { 26, 26, 1, "Available", null },
                    { 27, 27, 1, "Available", null },
                    { 28, 28, 1, "Available", null },
                    { 29, 29, 1, "Available", null },
                    { 30, 30, 1, "Available", null },
                    { 31, 31, 1, "Available", null },
                    { 32, 32, 1, "Available", null },
                    { 33, 33, 1, "Available", null },
                    { 34, 34, 1, "Available", null },
                    { 35, 35, 1, "Available", null },
                    { 36, 36, 1, "Available", null },
                    { 37, 37, 1, "Available", null },
                    { 38, 38, 1, "Available", null },
                    { 39, 39, 1, "Available", null },
                    { 40, 40, 1, "Available", null },
                    { 41, 41, 1, "Available", null },
                    { 42, 42, 1, "Available", null },
                    { 43, 43, 1, "Available", null },
                    { 44, 44, 1, "Available", null },
                    { 45, 45, 1, "Available", null },
                    { 46, 46, 1, "Available", null },
                    { 47, 47, 1, "Available", null },
                    { 48, 48, 1, "Available", null },
                    { 49, 49, 1, "Available", null },
                    { 50, 50, 1, "Available", null }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "Date", "ObraId", "SalaId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 27, 10, 4, 21, 5, DateTimeKind.Local).AddTicks(7674), 1, 1 },
                    { 2, new DateTime(2024, 3, 27, 10, 4, 21, 5, DateTimeKind.Local).AddTicks(7674), 2, 1 },
                    { 3, new DateTime(2024, 3, 27, 10, 4, 21, 5, DateTimeKind.Local).AddTicks(7674), 3, 1 },
                    { 4, new DateTime(2024, 3, 27, 10, 4, 21, 5, DateTimeKind.Local).AddTicks(7674), 4, 1 },
                    { 5, new DateTime(2024, 3, 27, 10, 4, 21, 5, DateTimeKind.Local).AddTicks(7674), 5, 1 },
                    { 6, new DateTime(2024, 3, 27, 10, 4, 21, 5, DateTimeKind.Local).AddTicks(7674), 6, 1 },
                    { 7, new DateTime(2024, 3, 27, 10, 4, 21, 5, DateTimeKind.Local).AddTicks(7674), 7, 1 },
                    { 8, new DateTime(2024, 3, 27, 10, 4, 21, 5, DateTimeKind.Local).AddTicks(7674), 8, 1 },
                    { 9, new DateTime(2024, 3, 27, 10, 4, 21, 5, DateTimeKind.Local).AddTicks(7674), 9, 1 },
                    { 10, new DateTime(2024, 3, 27, 10, 4, 21, 5, DateTimeKind.Local).AddTicks(7674), 10, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
