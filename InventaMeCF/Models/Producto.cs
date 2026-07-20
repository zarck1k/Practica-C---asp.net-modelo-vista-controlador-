using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventaMeCF.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioUnitario { get; set; }
        public string Descripcion { get; set; }
        public int MarcaId { get; set; }
        [ForeignKey("MarcaId")]
        public virtual Marca? Marca { get; set; }



    }
}
