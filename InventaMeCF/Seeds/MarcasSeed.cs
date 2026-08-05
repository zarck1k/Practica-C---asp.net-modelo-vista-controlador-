using InventaMeCF.Models;
using Microsoft.EntityFrameworkCore;

namespace InventaMeCF.Seeds
{
    public class MarcasSeed
    {
        public MarcasSeed(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Marca>().HasData(
                new Marca { Id = 1, Name = "Nike" },
                new Marca { Id = 2, Name = "Adidas" },
                new Marca { Id = 3, Name = "Puma" }
                );
        }
    }
}
