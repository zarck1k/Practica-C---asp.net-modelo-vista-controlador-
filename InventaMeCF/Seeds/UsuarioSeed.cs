using InventaMeCF.Models;
using Microsoft.EntityFrameworkCore;

namespace InventaMeCF.Seeds
{
    public class UsuarioSeed
    {
        public UsuarioSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    Id = 1,
                    Nombre = "Moies Aquio",
                    Correo = "moi@example.com",
                    Clave = "ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f"
                },
                 new Usuario
                 {
                     Id = 2,
                     Nombre = "Jhonatan Ralu",
                     Correo = "menr@example.com",
                     Clave = "1234567890abcdef1234567890abcdef1234567890abcdef1234567890abcdef"
                 },
                  new Usuario
                  {
                      Id = 3,
                      Nombre = "BEnido juares",
                      Correo = "bend2@example.com",
                      Clave = "1234567890abcdef1234567890abcdef1234567890abcdef1234567890abcdef"
                  }


                );
        }


    }
}
