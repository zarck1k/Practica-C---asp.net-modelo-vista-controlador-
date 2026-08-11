using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventaMeCF.Models
{
    public class DetalleVenta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        public int Cantidad { get; set; }

        [Precision(10, 4)]
        public decimal PrecioUnitario { get; set; }

        [Precision(10, 4)]
        public decimal Monto { get; set; }

        public int VentaId { get; set; }

        [ForeignKey("VentaId")]
        public virtual Venta? Venta { get; set; }

        public int ProductoId { get; set; }

        [ForeignKey("ProductoId")]
        public virtual Producto? Producto { get; set; }
    }
}
