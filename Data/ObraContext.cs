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

            modelBuilder.Entity<Seat>()
                .HasOne(s => s.User)
                .WithMany(u => u.Seats)
                .HasForeignKey(s => s.UserId);

          //Aqui establecemos las relaciones (Por ejemplo en este cada  sesion tiene una obra y una obra puede tener muchas sesiones.)
            modelBuilder.Entity<Session>()
                .HasOne(s => s.Obra)
                .WithMany(o => o.Sessions)
                .HasForeignKey(s => s.ObraId);

          
            modelBuilder.Entity<Seat>()
                .HasOne(s => s.Session)
                .WithMany(s => s.Seats)
                .HasForeignKey(s => s.SessionId)
                 .OnDelete(DeleteBehavior.NoAction);//Esto es por restricciones al borrar de cascada.
        }


        public DbSet<Obra> Obras { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Session> Sessions {get; set;}

    }
}
