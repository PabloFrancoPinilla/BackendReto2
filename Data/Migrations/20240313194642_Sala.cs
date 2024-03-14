using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeatroBack.Data.Migrations
{
    /// <inheritdoc />
    public partial class Sala : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Sessions_SessionId",
                table: "Seats");

            migrationBuilder.DropIndex(
                name: "IX_Seats_SessionId",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "Seats");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Sessions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "SalaId",
                table: "Sessions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SalaId",
                table: "Seats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Salas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    SessionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_SalaId",
                table: "Sessions",
                column: "SalaId");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_SalaId",
                table: "Seats",
                column: "SalaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Salas_SalaId",
                table: "Seats",
                column: "SalaId",
                principalTable: "Salas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Salas_SalaId",
                table: "Sessions",
                column: "SalaId",
                principalTable: "Salas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Salas_SalaId",
                table: "Seats");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Salas_SalaId",
                table: "Sessions");

            migrationBuilder.DropTable(
                name: "Salas");

            migrationBuilder.DropIndex(
                name: "IX_Sessions_SalaId",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Seats_SalaId",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "SalaId",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "SalaId",
                table: "Seats");

            migrationBuilder.AddColumn<int>(
                name: "SessionId",
                table: "Seats",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seats_SessionId",
                table: "Seats",
                column: "SessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Sessions_SessionId",
                table: "Seats",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id");
        }
    }
}
