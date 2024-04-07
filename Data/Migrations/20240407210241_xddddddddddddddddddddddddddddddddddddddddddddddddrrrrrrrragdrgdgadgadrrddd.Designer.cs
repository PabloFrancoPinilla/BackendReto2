﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeatroBack.Data;

#nullable disable

namespace TeatroBack.Data.Migrations
{
    [DbContext(typeof(ObraContext))]
    [Migration("20240407210241_xddddddddddddddddddddddddddddddddddddddddddddddddrrrrrrrragdrgdgadgadrrddd")]
    partial class xddddddddddddddddddddddddddddddddddddddddddddddddrrrrrrrragdrgdgadgadrrddd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TeatroBack.Models.Obra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Obras");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Un grupo de amigos se adentra en un faro abandonado en busca de respuestas, pero pronto descubren que no están solos y que el faro guarda oscuros secretos.",
                            Duration = "2 horas",
                            Genre = "Misterio",
                            Image = "https://www.taquilla.com/data/images/t/8e/laponia.jpg",
                            Name = "El misterio del faro"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Después de un naufragio, un grupo de supervivientes llega a una isla aparentemente desierta. Sin embargo, pronto se dan cuenta de que no están solos y que la isla esconde misterios que desafían la lógica.",
                            Duration = "2 horas",
                            Genre = "Misterio",
                            Image = "https://www.taquilla.com/data/images/t/3d/la-funcion-que-sale-mal.jpg",
                            Name = "La isla misteriosa"
                        },
                        new
                        {
                            Id = 3,
                            Description = "En un circo itinerante, los artistas guardan secretos tan intrigantes como sus actuaciones. Cuando un visitante curioso se adentra en su mundo, descubre un misterio que lo cambiará todo.",
                            Duration = "1 hora y 45 minutos",
                            Genre = "Misterio",
                            Image = "https://www.taquilla.com/data/images/t/de/adictos-con-lola-herrera.jpg",
                            Name = "El circo de los sueños"
                        },
                        new
                        {
                            Id = 4,
                            Description = "En un reino lejano, una princesa desaparece misteriosamente. Un joven aventurero emprende un viaje para encontrarla, enfrentándose a criaturas mágicas y desafíos inimaginables en el camino.",
                            Duration = "1 hora y 30 minutos",
                            Genre = "Fantasía",
                            Image = "https://www.atrapalo.com/common/photo/event/4/8/9/6736/1487635/si_372_0.jpg",
                            Name = "La princesa perdida"
                        },
                        new
                        {
                            Id = 5,
                            Description = "En un mundo donde los sueños se hacen realidad, un héroe improbable debe enfrentarse a sus mayores miedos y descubrir su verdadero destino para salvar a su reino de la oscuridad.",
                            Duration = "2 horas y 15 minutos",
                            Genre = "Fantasía",
                            Image = "https://d2cyzdatssrhg7.cloudfront.net/export/sites/default/ets/.content/products/img/00-00088m2.jpg?__locale=es",
                            Name = "El reino de los sueños"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Un joven aprendiz de mago se embarca en un viaje épico para dominar sus poderes y enfrentarse al malvado hechicero que amenaza con destruir su mundo.",
                            Duration = "2 horas y 30 minutos",
                            Genre = "Fantasía",
                            Image = "https://teatromadrid.com/wp-content/uploads/2022/09/Teatro-Madrid_WAH_MADRID_cartel.jpg",
                            Name = "El viaje del mago"
                        },
                        new
                        {
                            Id = 7,
                            Description = "En una isla remota, un grupo de cazatesoros busca la legendaria fortuna de un infame pirata. Pero no tardan en descubrir que la isla está llena de trampas mortales y rivalidades peligrosas.",
                            Duration = "2 horas y 15 minutos",
                            Genre = "Aventura",
                            Image = "https://www.taquilla.com/data/images/t/78/nada-es-imposible-el-mago-pop.jpg",
                            Name = "El tesoro del pirata"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Un intrépido explorador emprende una expedición peligrosa en busca de la legendaria estatua de un coloso perdido. Pero pronto descubre que no es el único que busca el tesoro, y que sus rivales están dispuestos a todo por encontrarlo primero.",
                            Duration = "2 horas y 30 minutos",
                            Genre = "Aventura",
                            Image = "https://teatrosluchana.es/wp-content/uploads/doble-o-nada-cartel.jpg",
                            Name = "La búsqueda del coloso"
                        },
                        new
                        {
                            Id = 9,
                            Description = "En lo profundo de la selva amazónica, un grupo de científicos tropieza con un antiguo misterio que podría cambiar nuestra comprensión de la historia. Pero también despiertan a una antigua fuerza que hará todo lo posible por mantener su secreto oculto.",
                            Duration = "2 horas",
                            Genre = "Aventura",
                            Image = "https://d2cyzdatssrhg7.cloudfront.net/export/sites/default/ets/.content/products/img/00-00085ZV.jpg?__locale=es",
                            Name = "El enigma de la jungla"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Un grupo de desconocidos recibe una invitación misteriosa para pasar la noche en una mansión aparentemente abandonada. Pronto descubren que no están solos y que alguien o algo los observa desde las sombras.",
                            Duration = "2 horas",
                            Genre = "Suspenso",
                            Image = "https://phantom-elmundo.unidadeditorial.es/eb6270f63ddf70149dde1fe54e34f364/resize/414/f/jpg/assets/multimedia/imagenes/2021/07/28/16274647454501.jpg",
                            Name = "La mansión encantada"
                        },
                        new
                        {
                            Id = 11,
                            Description = "En un pequeño pueblo, una casa aparentemente común esconde secretos inquietantes que han atormentado a sus habitantes durante generaciones. Cuando una familia decide mudarse allí, desatan fuerzas oscuras que amenazan con destruirlos.",
                            Duration = "2 horas",
                            Genre = "Suspenso",
                            Image = "https://ecientradaspropublicsa.blob.core.windows.net/edo-entradas-files/content_images/attachments/000/050/925/original/bisabis-morancos-400-504.jpg?2024",
                            Name = "La casa de los secretos"
                        },
                        new
                        {
                            Id = 12,
                            Description = "En lo alto de una colina solitaria, una comunidad aparentemente pacífica oculta secretos que podrían destruirlos a todos. Cuando un extraño llega al pueblo, desencadena una serie de eventos que revelan la verdadera naturaleza del lugar.",
                            Duration = "1 hora y 45 minutos",
                            Genre = "Suspenso",
                            Image = "https://phantom-elmundo.unidadeditorial.es/8f588dda47ba80862ca7090407d303e1/resize/414/f/jpg/assets/multimedia/imagenes/2021/07/28/16274647441407.jpg",
                            Name = "El secreto de la colina"
                        });
                });

            modelBuilder.Entity("TeatroBack.Models.Reserve", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("SeatId")
                        .HasColumnType("int");

                    b.Property<int>("SessionId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SeatId");

                    b.HasIndex("SessionId");

                    b.HasIndex("UserId");

                    b.ToTable("Reserves");
                });

            modelBuilder.Entity("TeatroBack.Models.Sala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("SessionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Salas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Number = 1,
                            SessionId = 1
                        });
                });

            modelBuilder.Entity("TeatroBack.Models.Seat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("SalaId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SalaId");

                    b.ToTable("Seats");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Number = 1,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 2,
                            Number = 2,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 3,
                            Number = 3,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 4,
                            Number = 4,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 5,
                            Number = 5,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 6,
                            Number = 6,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 7,
                            Number = 7,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 8,
                            Number = 8,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 9,
                            Number = 9,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 10,
                            Number = 10,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 11,
                            Number = 11,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 12,
                            Number = 12,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 13,
                            Number = 13,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 14,
                            Number = 14,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 15,
                            Number = 15,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 16,
                            Number = 16,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 17,
                            Number = 17,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 18,
                            Number = 18,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 19,
                            Number = 19,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 20,
                            Number = 20,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 21,
                            Number = 21,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 22,
                            Number = 22,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 23,
                            Number = 23,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 24,
                            Number = 24,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 25,
                            Number = 25,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 26,
                            Number = 26,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 27,
                            Number = 27,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 28,
                            Number = 28,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 29,
                            Number = 29,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 30,
                            Number = 30,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 31,
                            Number = 31,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 32,
                            Number = 32,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 33,
                            Number = 33,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 34,
                            Number = 34,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 35,
                            Number = 35,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 36,
                            Number = 36,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 37,
                            Number = 37,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 38,
                            Number = 38,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 39,
                            Number = 39,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 40,
                            Number = 40,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 41,
                            Number = 41,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 42,
                            Number = 42,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 43,
                            Number = 43,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 44,
                            Number = 44,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 45,
                            Number = 45,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 46,
                            Number = 46,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 47,
                            Number = 47,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 48,
                            Number = 48,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 49,
                            Number = 49,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        },
                        new
                        {
                            Id = 50,
                            Number = 50,
                            Price = 9.9900000000000002,
                            SalaId = 1,
                            State = "Available"
                        });
                });

            modelBuilder.Entity("TeatroBack.Models.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ObraId")
                        .HasColumnType("int");

                    b.Property<int>("SalaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ObraId");

                    b.HasIndex("SalaId");

                    b.ToTable("Sessions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2024, 4, 14, 23, 2, 41, 526, DateTimeKind.Local).AddTicks(4190),
                            ObraId = 1,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2024, 4, 14, 23, 2, 41, 526, DateTimeKind.Local).AddTicks(4190),
                            ObraId = 2,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2024, 4, 14, 23, 2, 41, 526, DateTimeKind.Local).AddTicks(4190),
                            ObraId = 3,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2024, 4, 14, 23, 2, 41, 526, DateTimeKind.Local).AddTicks(4190),
                            ObraId = 4,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2024, 4, 14, 23, 2, 41, 526, DateTimeKind.Local).AddTicks(4190),
                            ObraId = 5,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2024, 4, 14, 23, 2, 41, 526, DateTimeKind.Local).AddTicks(4190),
                            ObraId = 6,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2024, 4, 14, 23, 2, 41, 526, DateTimeKind.Local).AddTicks(4190),
                            ObraId = 7,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateTime(2024, 4, 14, 23, 2, 41, 526, DateTimeKind.Local).AddTicks(4190),
                            ObraId = 8,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateTime(2024, 4, 14, 23, 2, 41, 526, DateTimeKind.Local).AddTicks(4190),
                            ObraId = 9,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 10,
                            Date = new DateTime(2024, 4, 14, 23, 2, 41, 526, DateTimeKind.Local).AddTicks(4190),
                            ObraId = 10,
                            SalaId = 1
                        });
                });

            modelBuilder.Entity("TeatroBack.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            LastName = "admin",
                            Mail = "admin",
                            Name = "admin",
                            Password = "admin"
                        },
                        new
                        {
                            Id = 1,
                            LastName = "noregister",
                            Mail = "noregister",
                            Name = "noregister",
                            Password = "noregister"
                        });
                });

            modelBuilder.Entity("TeatroBack.Models.Reserve", b =>
                {
                    b.HasOne("TeatroBack.Models.Seat", "Seat")
                        .WithMany()
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TeatroBack.Models.Session", "Session")
                        .WithMany()
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TeatroBack.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Seat");

                    b.Navigation("Session");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TeatroBack.Models.Seat", b =>
                {
                    b.HasOne("TeatroBack.Models.Sala", "Sala")
                        .WithMany("Seats")
                        .HasForeignKey("SalaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Sala");
                });

            modelBuilder.Entity("TeatroBack.Models.Session", b =>
                {
                    b.HasOne("TeatroBack.Models.Obra", "Obra")
                        .WithMany("Sessions")
                        .HasForeignKey("ObraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeatroBack.Models.Sala", "Sala")
                        .WithMany("Sessions")
                        .HasForeignKey("SalaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Obra");

                    b.Navigation("Sala");
                });

            modelBuilder.Entity("TeatroBack.Models.Obra", b =>
                {
                    b.Navigation("Sessions");
                });

            modelBuilder.Entity("TeatroBack.Models.Sala", b =>
                {
                    b.Navigation("Seats");

                    b.Navigation("Sessions");
                });
#pragma warning restore 612, 618
        }
    }
}
