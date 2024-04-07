using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeatroBack.Data.Migrations
{
    /// <inheritdoc />
    public partial class xddddddddddddddddddddddddddddddddddddddddddddddddrrrrrrrragdrgdgadgadrrddd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://www.taquilla.com/data/images/t/8e/laponia.jpg");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://www.taquilla.com/data/images/t/3d/la-funcion-que-sale-mal.jpg");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://www.taquilla.com/data/images/t/de/adictos-con-lola-herrera.jpg");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "https://www.atrapalo.com/common/photo/event/4/8/9/6736/1487635/si_372_0.jpg");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "https://d2cyzdatssrhg7.cloudfront.net/export/sites/default/ets/.content/products/img/00-00088m2.jpg?__locale=es");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "https://teatromadrid.com/wp-content/uploads/2022/09/Teatro-Madrid_WAH_MADRID_cartel.jpg");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "https://www.taquilla.com/data/images/t/78/nada-es-imposible-el-mago-pop.jpg");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "https://teatrosluchana.es/wp-content/uploads/doble-o-nada-cartel.jpg");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "https://d2cyzdatssrhg7.cloudfront.net/export/sites/default/ets/.content/products/img/00-00085ZV.jpg?__locale=es");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "https://phantom-elmundo.unidadeditorial.es/eb6270f63ddf70149dde1fe54e34f364/resize/414/f/jpg/assets/multimedia/imagenes/2021/07/28/16274647454501.jpg");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 11,
                column: "Image",
                value: "https://ecientradaspropublicsa.blob.core.windows.net/edo-entradas-files/content_images/attachments/000/050/925/original/bisabis-morancos-400-504.jpg?2024");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 12,
                column: "Image",
                value: "https://phantom-elmundo.unidadeditorial.es/8f588dda47ba80862ca7090407d303e1/resize/414/f/jpg/assets/multimedia/imagenes/2021/07/28/16274647441407.jpg");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 14, 23, 2, 41, 526, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 4, 14, 23, 2, 41, 526, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 4, 14, 23, 2, 41, 526, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 4, 14, 23, 2, 41, 526, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 4, 14, 23, 2, 41, 526, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 4, 14, 23, 2, 41, 526, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 4, 14, 23, 2, 41, 526, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 4, 14, 23, 2, 41, 526, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 4, 14, 23, 2, 41, 526, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 4, 14, 23, 2, 41, 526, DateTimeKind.Local).AddTicks(4190));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "faro.jpg");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "isla.jpg");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "circo.jpg");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "princesa.jpg");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "reino.jpg");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "magia.jpg");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "pirata.jpg");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "coloso.jpg");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "jungla.jpg");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "mansión.jpg");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 11,
                column: "Image",
                value: "casa.jpg");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "Id",
                keyValue: 12,
                column: "Image",
                value: "colina.jpg");

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
        }
    }
}
