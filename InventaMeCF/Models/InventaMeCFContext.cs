using Microsoft.EntityFrameworkCore;


namespace InventaMeCF.Models
{
    public class InventaMeCFContext:DbContext
    {
        public InventaMeCFContext(DbContextOptions<InventaMeCFContext> options) : base(options)
        {

        }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<UnidadMedida> UnidadMedidas { get; set; }
    }
}
