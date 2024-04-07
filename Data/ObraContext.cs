using Microsoft.EntityFrameworkCore;
using TeatroBack.Models;
using Microsoft.Extensions.Configuration;

namespace TeatroBack.Data
{
    public class ObraContext : DbContext
    {

        public ObraContext(DbContextOptions<ObraContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            //Aqui establecemos las relaciones (Por ejemplo en este cada  asiento tiene un usuario y un usuario puede tener muchos asientos.)


            //Aqui establecemos las relaciones (Por ejemplo en este cada  sesion tiene una obra y una obra puede tener muchas sesiones.)
            modelBuilder.Entity<Session>()
                .HasOne(s => s.Obra)
                .WithMany(o => o.Sessions)
                .HasForeignKey(s => s.ObraId);


            modelBuilder.Entity<Session>()
                          .HasOne(s => s.Sala)
                          .WithMany(s => s.Sessions)
                          .HasForeignKey(s => s.SalaId)
                          .OnDelete(DeleteBehavior.NoAction); //Esto es por restricciones al borrar de cascada.

            modelBuilder.Entity<Seat>()
               .HasOne(s => s.Sala)
               .WithMany(s => s.Seats)
               .HasForeignKey(s => s.SalaId)
               .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Reserve>()
            .HasOne(r => r.Seat)
            .WithMany()
            .HasForeignKey(r => r.SeatId)
            .OnDelete(DeleteBehavior.Restrict);

            // Relación Reserva - Session
            modelBuilder.Entity<Reserve>()
                .HasOne(r => r.Session)
                .WithMany()
                .HasForeignKey(r => r.SessionId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relación Reserva - User
            modelBuilder.Entity<Reserve>()
                .HasOne(r => r.User)
                .WithMany()
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Obra>().HasData(
                new Obra { Id = 1, Name = "El misterio del faro", Image = "faro.jpg", Duration = "2 horas", Genre = "Misterio", Description = "Hehequeloco" },
                new Obra { Id = 2, Name = "La princesa perdida", Image = "princesa.jpg", Duration = "1 hora y 30 minutos", Genre = "Fantasía", Description = "Hehequeloco" },
                new Obra { Id = 3, Name = "El tesoro del pirata", Image = "pirata.jpg", Duration = "2 horas y 15 minutos", Genre = "Aventura", Description = "Hehequeloco" },
                new Obra { Id = 4, Name = "La mansión encantada", Image = "mansión.jpg", Duration = "2 horas", Genre = "Suspenso", Description = "Hehequeloco" },
                new Obra { Id = 5, Name = "El circo de los sueños", Image = "circo.jpg", Duration = "1 hora y 45 minutos", Genre = "Drama", Description = "Hehequeloco" },
                new Obra { Id = 6, Name = "El secreto de la montaña", Image = "montaña.jpg", Duration = "2 horas y 30 minutos", Genre = "Aventura", Description = "Hehequeloco" },
                new Obra { Id = 7, Name = "La isla misteriosa", Image = "isla.jpg", Duration = "2 horas", Genre = "Misterio", Description = "Hehequeloco" },
                new Obra { Id = 8, Name = "El príncipe y la doncella", Image = "principe.jpg", Duration = "1 hora y 30 minutos", Genre = "Romance", Description = "Hehequeloco" },
                new Obra { Id = 9, Name = "La leyenda del caballero", Image = "caballero.jpg", Duration = "2 horas y 15 minutos", Genre = "Fantasía", Description = "Hehequeloco" },
                new Obra { Id = 10, Name = "La casa de los secretos", Image = "casa.jpg", Duration = "2 horas", Genre = "Suspenso", Description = "Hehequeloco" }
);
            modelBuilder.Entity<Sala>().HasData(
                 new Sala { Id = 1, Number = 1, SessionId = 1 }
                 );


            for (int i = 1; i <= 50; i++)
            {
                modelBuilder.Entity<Seat>().HasData(
                    new Seat { Id = i, Number = i, Price = 9.99, State = "Available", SalaId = 1, }
                );
            }


            var fechaSesion = DateTime.Now.AddDays(7); // Ejemplo de fecha: 7 días después de hoy
            for (int i = 1; i <= 10; i++)
            {
                modelBuilder.Entity<Session>().HasData(
                    new Session { Id = i, ObraId = i, Date = fechaSesion, SalaId = 1 }
                );
            }

        }


        public DbSet<Obra> Obras { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Reserve> Reserves { get; set; }


    }
}
