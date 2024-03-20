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
    [Migration("20240320172422_Context2")]
    partial class Context2
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
                            Duration = "2 horas",
                            Genre = "Misterio",
                            Image = "faro.jpg",
                            Name = "El misterio del faro"
                        },
                        new
                        {
                            Id = 2,
                            Duration = "1 hora y 30 minutos",
                            Genre = "Fantasía",
                            Image = "princesa.jpg",
                            Name = "La princesa perdida"
                        },
                        new
                        {
                            Id = 3,
                            Duration = "2 horas y 15 minutos",
                            Genre = "Aventura",
                            Image = "pirata.jpg",
                            Name = "El tesoro del pirata"
                        },
                        new
                        {
                            Id = 4,
                            Duration = "2 horas",
                            Genre = "Suspenso",
                            Image = "mansión.jpg",
                            Name = "La mansión encantada"
                        },
                        new
                        {
                            Id = 5,
                            Duration = "1 hora y 45 minutos",
                            Genre = "Drama",
                            Image = "circo.jpg",
                            Name = "El circo de los sueños"
                        },
                        new
                        {
                            Id = 6,
                            Duration = "2 horas y 30 minutos",
                            Genre = "Aventura",
                            Image = "montaña.jpg",
                            Name = "El secreto de la montaña"
                        },
                        new
                        {
                            Id = 7,
                            Duration = "2 horas",
                            Genre = "Misterio",
                            Image = "isla.jpg",
                            Name = "La isla misteriosa"
                        },
                        new
                        {
                            Id = 8,
                            Duration = "1 hora y 30 minutos",
                            Genre = "Romance",
                            Image = "principe.jpg",
                            Name = "El príncipe y la doncella"
                        },
                        new
                        {
                            Id = 9,
                            Duration = "2 horas y 15 minutos",
                            Genre = "Fantasía",
                            Image = "caballero.jpg",
                            Name = "La leyenda del caballero"
                        },
                        new
                        {
                            Id = 10,
                            Duration = "2 horas",
                            Genre = "Suspenso",
                            Image = "casa.jpg",
                            Name = "La casa de los secretos"
                        });
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

                    b.Property<int>("SalaId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SalaId");

                    b.HasIndex("UserId");

                    b.ToTable("Seats");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Number = 1,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 2,
                            Number = 2,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 3,
                            Number = 3,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 4,
                            Number = 4,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 5,
                            Number = 5,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 6,
                            Number = 6,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 7,
                            Number = 7,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 8,
                            Number = 8,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 9,
                            Number = 9,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 10,
                            Number = 10,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 11,
                            Number = 11,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 12,
                            Number = 12,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 13,
                            Number = 13,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 14,
                            Number = 14,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 15,
                            Number = 15,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 16,
                            Number = 16,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 17,
                            Number = 17,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 18,
                            Number = 18,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 19,
                            Number = 19,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 20,
                            Number = 20,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 21,
                            Number = 21,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 22,
                            Number = 22,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 23,
                            Number = 23,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 24,
                            Number = 24,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 25,
                            Number = 25,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 26,
                            Number = 26,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 27,
                            Number = 27,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 28,
                            Number = 28,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 29,
                            Number = 29,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 30,
                            Number = 30,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 31,
                            Number = 31,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 32,
                            Number = 32,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 33,
                            Number = 33,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 34,
                            Number = 34,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 35,
                            Number = 35,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 36,
                            Number = 36,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 37,
                            Number = 37,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 38,
                            Number = 38,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 39,
                            Number = 39,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 40,
                            Number = 40,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 41,
                            Number = 41,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 42,
                            Number = 42,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 43,
                            Number = 43,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 44,
                            Number = 44,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 45,
                            Number = 45,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 46,
                            Number = 46,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 47,
                            Number = 47,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 48,
                            Number = 48,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 49,
                            Number = 49,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
                        },
                        new
                        {
                            Id = 50,
                            Number = 50,
                            SalaId = 1,
                            State = "Available",
                            UserId = 0
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
                            Date = new DateTime(2024, 3, 27, 18, 24, 22, 336, DateTimeKind.Local).AddTicks(7715),
                            ObraId = 1,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2024, 3, 27, 18, 24, 22, 336, DateTimeKind.Local).AddTicks(7715),
                            ObraId = 2,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2024, 3, 27, 18, 24, 22, 336, DateTimeKind.Local).AddTicks(7715),
                            ObraId = 3,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2024, 3, 27, 18, 24, 22, 336, DateTimeKind.Local).AddTicks(7715),
                            ObraId = 4,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2024, 3, 27, 18, 24, 22, 336, DateTimeKind.Local).AddTicks(7715),
                            ObraId = 5,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2024, 3, 27, 18, 24, 22, 336, DateTimeKind.Local).AddTicks(7715),
                            ObraId = 6,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2024, 3, 27, 18, 24, 22, 336, DateTimeKind.Local).AddTicks(7715),
                            ObraId = 7,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateTime(2024, 3, 27, 18, 24, 22, 336, DateTimeKind.Local).AddTicks(7715),
                            ObraId = 8,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateTime(2024, 3, 27, 18, 24, 22, 336, DateTimeKind.Local).AddTicks(7715),
                            ObraId = 9,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 10,
                            Date = new DateTime(2024, 3, 27, 18, 24, 22, 336, DateTimeKind.Local).AddTicks(7715),
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

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TeatroBack.Models.Seat", b =>
                {
                    b.HasOne("TeatroBack.Models.Sala", "Sala")
                        .WithMany("Seats")
                        .HasForeignKey("SalaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TeatroBack.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Sala");

                    b.Navigation("User");
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
