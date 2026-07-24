using InventaMeCF.Seeds;
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
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            new UsuarioSeed(modelBuilder); //Esto concedta con la carpeta seeds para poder migrar esos seders
            new MarcasSeed(modelBuilder);
            new ProductoSeed(modelBuilder);
        }

    }

}
