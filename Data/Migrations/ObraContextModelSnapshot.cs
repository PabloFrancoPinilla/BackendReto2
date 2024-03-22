﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeatroBack.Data;

#nullable disable

namespace TeatroBack.Data.Migrations
{
    [DbContext(typeof(ObraContext))]
    partial class ObraContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<double>("Price")
                        .HasColumnType("float");

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
                            Date = new DateTime(2024, 3, 29, 17, 35, 55, 797, DateTimeKind.Local).AddTicks(5368),
                            ObraId = 1,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2024, 3, 29, 17, 35, 55, 797, DateTimeKind.Local).AddTicks(5368),
                            ObraId = 2,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2024, 3, 29, 17, 35, 55, 797, DateTimeKind.Local).AddTicks(5368),
                            ObraId = 3,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2024, 3, 29, 17, 35, 55, 797, DateTimeKind.Local).AddTicks(5368),
                            ObraId = 4,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2024, 3, 29, 17, 35, 55, 797, DateTimeKind.Local).AddTicks(5368),
                            ObraId = 5,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2024, 3, 29, 17, 35, 55, 797, DateTimeKind.Local).AddTicks(5368),
                            ObraId = 6,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2024, 3, 29, 17, 35, 55, 797, DateTimeKind.Local).AddTicks(5368),
                            ObraId = 7,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateTime(2024, 3, 29, 17, 35, 55, 797, DateTimeKind.Local).AddTicks(5368),
                            ObraId = 8,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateTime(2024, 3, 29, 17, 35, 55, 797, DateTimeKind.Local).AddTicks(5368),
                            ObraId = 9,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 10,
                            Date = new DateTime(2024, 3, 29, 17, 35, 55, 797, DateTimeKind.Local).AddTicks(5368),
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
