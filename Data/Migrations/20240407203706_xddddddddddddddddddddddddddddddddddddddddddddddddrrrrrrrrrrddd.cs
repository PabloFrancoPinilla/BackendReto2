using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeatroBack.Data.Migrations
{
    /// <inheritdoc />
    public partial class xddddddddddddddddddddddddddddddddddddddddddddddddrrrrrrrrrrddd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Un grupo de amigos se adentra en un faro abandonado en busca de respuestas, pero pronto descubren que no están solos y que el faro guarda oscuros secretos.");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Duration", "Genre", "Image", "Name" },
                values: new object[] { "Después de un naufragio, un grupo de supervivientes llega a una isla aparentemente desierta. Sin embargo, pronto se dan cuenta de que no están solos y que la isla esconde misterios que desafían la lógica.", "2 horas", "Misterio", "isla.jpg", "La isla misteriosa" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Duration", "Genre", "Image", "Name" },
                values: new object[] { "En un circo itinerante, los artistas guardan secretos tan intrigantes como sus actuaciones. Cuando un visitante curioso se adentra en su mundo, descubre un misterio que lo cambiará todo.", "1 hora y 45 minutos", "Misterio", "circo.jpg", "El circo de los sueños" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Duration", "Genre", "Image", "Name" },
                values: new object[] { "En un reino lejano, una princesa desaparece misteriosamente. Un joven aventurero emprende un viaje para encontrarla, enfrentándose a criaturas mágicas y desafíos inimaginables en el camino.", "1 hora y 30 minutos", "Fantasía", "princesa.jpg", "La princesa perdida" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Duration", "Genre", "Image", "Name" },
                values: new object[] { "En un mundo donde los sueños se hacen realidad, un héroe improbable debe enfrentarse a sus mayores miedos y descubrir su verdadero destino para salvar a su reino de la oscuridad.", "2 horas y 15 minutos", "Fantasía", "reino.jpg", "El reino de los sueños" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Genre", "Image", "Name" },
                values: new object[] { "Un joven aprendiz de mago se embarca en un viaje épico para dominar sus poderes y enfrentarse al malvado hechicero que amenaza con destruir su mundo.", "Fantasía", "magia.jpg", "El viaje del mago" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Duration", "Genre", "Image", "Name" },
                values: new object[] { "En una isla remota, un grupo de cazatesoros busca la legendaria fortuna de un infame pirata. Pero no tardan en descubrir que la isla está llena de trampas mortales y rivalidades peligrosas.", "2 horas y 15 minutos", "Aventura", "pirata.jpg", "El tesoro del pirata" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Duration", "Genre", "Image", "Name" },
                values: new object[] { "Un intrépido explorador emprende una expedición peligrosa en busca de la legendaria estatua de un coloso perdido. Pero pronto descubre que no es el único que busca el tesoro, y que sus rivales están dispuestos a todo por encontrarlo primero.", "2 horas y 30 minutos", "Aventura", "coloso.jpg", "La búsqueda del coloso" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Duration", "Genre", "Image", "Name" },
                values: new object[] { "En lo profundo de la selva amazónica, un grupo de científicos tropieza con un antiguo misterio que podría cambiar nuestra comprensión de la historia. Pero también despiertan a una antigua fuerza que hará todo lo posible por mantener su secreto oculto.", "2 horas", "Aventura", "jungla.jpg", "El enigma de la jungla" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Un grupo de desconocidos recibe una invitación misteriosa para pasar la noche en una mansión aparentemente abandonada. Pronto descubren que no están solos y que alguien o algo los observa desde las sombras.", "mansión.jpg", "La mansión encantada" });

            migrationBuilder.InsertData(
                table: "Obras",
                columns: new[] { "Id", "Description", "Duration", "Genre", "Image", "Name" },
                values: new object[,]
                {
                    { 11, "En un pequeño pueblo, una casa aparentemente común esconde secretos inquietantes que han atormentado a sus habitantes durante generaciones. Cuando una familia decide mudarse allí, desatan fuerzas oscuras que amenazan con destruirlos.", "2 horas", "Suspenso", "casa.jpg", "La casa de los secretos" },
                    { 12, "En lo alto de una colina solitaria, una comunidad aparentemente pacífica oculta secretos que podrían destruirlos a todos. Cuando un extraño llega al pueblo, desencadena una serie de eventos que revelan la verdadera naturaleza del lugar.", "1 hora y 45 minutos", "Suspenso", "colina.jpg", "El secreto de la colina" }
                });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 14, 22, 37, 6, 795, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 4, 14, 22, 37, 6, 795, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 4, 14, 22, 37, 6, 795, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 4, 14, 22, 37, 6, 795, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 4, 14, 22, 37, 6, 795, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 4, 14, 22, 37, 6, 795, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 4, 14, 22, 37, 6, 795, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 4, 14, 22, 37, 6, 795, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 4, 14, 22, 37, 6, 795, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 4, 14, 22, 37, 6, 795, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "LastName", "Mail", "Name", "Password" },
                values: new object[,]
                {
                    { -1, "admin", "admin", "admin", "admin" },
                    { 1, "noregister", "noregister", "noregister", "noregister" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

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
                columns: new[] { "Description", "Duration", "Genre", "Image", "Name" },
                values: new object[] { "Hehequeloco", "1 hora y 30 minutos", "Fantasía", "princesa.jpg", "La princesa perdida" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Duration", "Genre", "Image", "Name" },
                values: new object[] { "Hehequeloco", "2 horas y 15 minutos", "Aventura", "pirata.jpg", "El tesoro del pirata" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Duration", "Genre", "Image", "Name" },
                values: new object[] { "Hehequeloco", "2 horas", "Suspenso", "mansión.jpg", "La mansión encantada" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Duration", "Genre", "Image", "Name" },
                values: new object[] { "Hehequeloco", "1 hora y 45 minutos", "Drama", "circo.jpg", "El circo de los sueños" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Genre", "Image", "Name" },
                values: new object[] { "Hehequeloco", "Aventura", "montaña.jpg", "El secreto de la montaña" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Duration", "Genre", "Image", "Name" },
                values: new object[] { "Hehequeloco", "2 horas", "Misterio", "isla.jpg", "La isla misteriosa" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Duration", "Genre", "Image", "Name" },
                values: new object[] { "Hehequeloco", "1 hora y 30 minutos", "Romance", "principe.jpg", "El príncipe y la doncella" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Duration", "Genre", "Image", "Name" },
                values: new object[] { "Hehequeloco", "2 horas y 15 minutos", "Fantasía", "caballero.jpg", "La leyenda del caballero" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Hehequeloco", "casa.jpg", "La casa de los secretos" });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 14, 18, 11, 24, 735, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 4, 14, 18, 11, 24, 735, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 4, 14, 18, 11, 24, 735, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 4, 14, 18, 11, 24, 735, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 4, 14, 18, 11, 24, 735, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 4, 14, 18, 11, 24, 735, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 4, 14, 18, 11, 24, 735, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 4, 14, 18, 11, 24, 735, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 4, 14, 18, 11, 24, 735, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 4, 14, 18, 11, 24, 735, DateTimeKind.Local).AddTicks(3529));
        }
    }
}
