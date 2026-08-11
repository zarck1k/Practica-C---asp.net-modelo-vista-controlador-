using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventaMeCF.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("Nombre", TypeName = "varchar(80)")]
        public string? Nombre { get; set; }

        public virtual ICollection<Venta> Ventas { get; set; }
    }
}
