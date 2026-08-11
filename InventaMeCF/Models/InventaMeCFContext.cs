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
        public DbSet<Rol> Roles { get; set; }
        public DbSet<RolAsignado> RolesAsignados { get; set; }

        public DbSet<Cliente> Clientes { get; set; } // Línea agregada
        public DbSet<Venta> Ventas { get; set; } // Línea agregada
        public DbSet<DetalleVenta> DetalleVentas { get; set; } // Línea agregada


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            new UsuarioSeed(modelBuilder); //Esto concedta con la carpeta seeds para poder migrar esos seders
            new MarcasSeed(modelBuilder);
            new ProductoSeed(modelBuilder);
            new RolSeed(modelBuilder);
            new RolAsignadoSeed(modelBuilder);
        }

    }
    

    }

