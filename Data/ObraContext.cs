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
            /*    modelBuilder.Entity<Obra>().HasData(
                  new Obra {Id=1, Name = "Pepeorino", IsGlutenFree = true},
                  new Obra { Id=2,Name = "Bacon", IsGlutenFree = false}
              );
              modelBuilder.Entity<Ingrediente>().HasData(
                  new Ingrediente {Id=1,  Name = "Cebolla", Origin="Vegetable", Stock = 100, Description = "Deposito inicial", IsVegan = true},
                  new Ingrediente { Id=2, Name = "Pepeorino", Origin="Animal", Stock = 100, Description = "Deposito", IsVegan= false},
                  new Ingrediente { Id=3, Name = "Tomato", Origin="Vegetal", Stock = 100, Description = "Retiro", IsVegan= true},
                  new Ingrediente { Id=4, Name = "Cheese", Origin="Animal", Stock = 100, Description = "Deposito", IsVegan=false}
              ); */


            modelBuilder.Entity<Obra>()
                .HasMany(obra => obra.Seats)
                .WithOne(seat => seat.Obra)
                .HasForeignKey(seat => seat.ObraId);


        }

        public DbSet<Obra> Obras { get; set; }
        public DbSet<Seat> Seats { get; set; }

    }
}
