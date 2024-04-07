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
                new Obra { Id = 1, Name = "El misterio del faro", Image = "https://www.taquilla.com/data/images/t/8e/laponia.jpg", Duration = "2 horas", Genre = "Misterio", Description = "Un grupo de amigos se adentra en un faro abandonado en busca de respuestas, pero pronto descubren que no están solos y que el faro guarda oscuros secretos." },
                new Obra { Id = 2, Name = "La isla misteriosa", Image = "https://www.taquilla.com/data/images/t/3d/la-funcion-que-sale-mal.jpg", Duration = "2 horas", Genre = "Misterio", Description = "Después de un naufragio, un grupo de supervivientes llega a una isla aparentemente desierta. Sin embargo, pronto se dan cuenta de que no están solos y que la isla esconde misterios que desafían la lógica." },
                new Obra { Id = 3, Name = "El circo de los sueños", Image = "https://www.taquilla.com/data/images/t/de/adictos-con-lola-herrera.jpg", Duration = "1 hora y 45 minutos", Genre = "Misterio", Description = "En un circo itinerante, los artistas guardan secretos tan intrigantes como sus actuaciones. Cuando un visitante curioso se adentra en su mundo, descubre un misterio que lo cambiará todo." },

                new Obra { Id = 4, Name = "La princesa perdida", Image = "https://www.atrapalo.com/common/photo/event/4/8/9/6736/1487635/si_372_0.jpg", Duration = "1 hora y 30 minutos", Genre = "Fantasía", Description = "En un reino lejano, una princesa desaparece misteriosamente. Un joven aventurero emprende un viaje para encontrarla, enfrentándose a criaturas mágicas y desafíos inimaginables en el camino." },
                new Obra { Id = 5, Name = "El reino de los sueños", Image = "https://d2cyzdatssrhg7.cloudfront.net/export/sites/default/ets/.content/products/img/00-00088m2.jpg?__locale=es", Duration = "2 horas y 15 minutos", Genre = "Fantasía", Description = "En un mundo donde los sueños se hacen realidad, un héroe improbable debe enfrentarse a sus mayores miedos y descubrir su verdadero destino para salvar a su reino de la oscuridad." },
                new Obra { Id = 6, Name = "El viaje del mago", Image = "https://teatromadrid.com/wp-content/uploads/2022/09/Teatro-Madrid_WAH_MADRID_cartel.jpg", Duration = "2 horas y 30 minutos", Genre = "Fantasía", Description = "Un joven aprendiz de mago se embarca en un viaje épico para dominar sus poderes y enfrentarse al malvado hechicero que amenaza con destruir su mundo." },

                new Obra { Id = 7, Name = "El tesoro del pirata", Image = "https://www.taquilla.com/data/images/t/78/nada-es-imposible-el-mago-pop.jpg", Duration = "2 horas y 15 minutos", Genre = "Aventura", Description = "En una isla remota, un grupo de cazatesoros busca la legendaria fortuna de un infame pirata. Pero no tardan en descubrir que la isla está llena de trampas mortales y rivalidades peligrosas." },
                new Obra { Id = 8, Name = "La búsqueda del coloso", Image = "https://teatrosluchana.es/wp-content/uploads/doble-o-nada-cartel.jpg", Duration = "2 horas y 30 minutos", Genre = "Aventura", Description = "Un intrépido explorador emprende una expedición peligrosa en busca de la legendaria estatua de un coloso perdido. Pero pronto descubre que no es el único que busca el tesoro, y que sus rivales están dispuestos a todo por encontrarlo primero." },
                new Obra { Id = 9, Name = "El enigma de la jungla", Image = "https://d2cyzdatssrhg7.cloudfront.net/export/sites/default/ets/.content/products/img/00-00085ZV.jpg?__locale=es", Duration = "2 horas", Genre = "Aventura", Description = "En lo profundo de la selva amazónica, un grupo de científicos tropieza con un antiguo misterio que podría cambiar nuestra comprensión de la historia. Pero también despiertan a una antigua fuerza que hará todo lo posible por mantener su secreto oculto." },

                new Obra { Id = 10, Name = "La mansión encantada", Image = "https://phantom-elmundo.unidadeditorial.es/eb6270f63ddf70149dde1fe54e34f364/resize/414/f/jpg/assets/multimedia/imagenes/2021/07/28/16274647454501.jpg", Duration = "2 horas", Genre = "Suspenso", Description = "Un grupo de desconocidos recibe una invitación misteriosa para pasar la noche en una mansión aparentemente abandonada. Pronto descubren que no están solos y que alguien o algo los observa desde las sombras." },
                new Obra { Id = 11, Name = "La casa de los secretos", Image = "https://ecientradaspropublicsa.blob.core.windows.net/edo-entradas-files/content_images/attachments/000/050/925/original/bisabis-morancos-400-504.jpg?2024", Duration = "2 horas", Genre = "Suspenso", Description = "En un pequeño pueblo, una casa aparentemente común esconde secretos inquietantes que han atormentado a sus habitantes durante generaciones. Cuando una familia decide mudarse allí, desatan fuerzas oscuras que amenazan con destruirlos." },
                new Obra { Id = 12, Name = "El secreto de la colina", Image = "https://phantom-elmundo.unidadeditorial.es/8f588dda47ba80862ca7090407d303e1/resize/414/f/jpg/assets/multimedia/imagenes/2021/07/28/16274647441407.jpg", Duration = "1 hora y 45 minutos", Genre = "Suspenso", Description = "En lo alto de una colina solitaria, una comunidad aparentemente pacífica oculta secretos que podrían destruirlos a todos. Cuando un extraño llega al pueblo, desencadena una serie de eventos que revelan la verdadera naturaleza del lugar." }
);
            modelBuilder.Entity<Sala>().HasData(
                 new Sala { Id = 1, Number = 1, SessionId = 1 }
                 );

            modelBuilder.Entity<User>().HasData(
                new User { Id = -1, Name = "admin", LastName = "admin", Mail = "admin", Password = "admin" },
                new User { Id = 1, Name = "noregister", LastName = "noregister", Mail = "noregister", Password = "noregister" }
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
