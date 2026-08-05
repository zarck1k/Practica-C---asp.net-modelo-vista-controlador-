using InventaMeCF.Models;
using Microsoft.EntityFrameworkCore;
namespace InventaMeCF.Seeds

{
    public class ProductoSeed
    {
        public ProductoSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().HasData(
  new Producto { Id = 1, Nombre = "Nike Air Max 90", PrecioUnitario = 120.00m, Descripcion = "Tenis deportivos para uso diario.", MarcaId = 1 },
    new Producto { Id = 2, Nombre = "Nike Revolution 7", PrecioUnitario = 85.50m, Descripcion = "Calzado ligero para correr.", MarcaId = 1 },
    new Producto { Id = 3, Nombre = "Adidas Ultraboost", PrecioUnitario = 180.00m, Descripcion = "Tenis deportivos con gran comodidad.", MarcaId = 2 },
    new Producto { Id = 4, Nombre = "Adidas Predator", PrecioUnitario = 95.99m, Descripcion = "Zapatos para fútbol.", MarcaId = 2 },
    new Producto { Id = 5, Nombre = "Puma Smash V2", PrecioUnitario = 70.00m, Descripcion = "Tenis casuales unisex.", MarcaId = 3 },
    new Producto { Id = 6, Nombre = "Puma Future Rider", PrecioUnitario = 110.75m, Descripcion = "Calzado deportivo moderno.", MarcaId = 3 }
                );
        }

    }
}
