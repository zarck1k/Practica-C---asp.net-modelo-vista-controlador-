using InventaMeCF.Models;
using Microsoft.EntityFrameworkCore;

namespace InventaMeCF.Seeds
{
    public class UsuarioSeed
    {
        public UsuarioSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { Id = 4, Nombre = "miguel", Correo = "mcortez_vasquez@yahoo.com", Clave = "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918" },
                new Usuario { Id = 5, Nombre = "andrea", Correo = "andrea@gmail.com", Clave = "6bab3007f56e2a9175ff1222c2654ddcd08fa7981a1ddc42f1d95cfbd80ede47" },
                new Usuario { Id = 6, Nombre = "daniel", Correo = "daniel@gmail.com", Clave = "a29bb351ab7025926eb34a77f0485a0f8ab9dc993009f990cbd8eabbf0d947e3" }
            );
        }


    }
}
