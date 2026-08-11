using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventaMeCF.Models
{
    public class Venta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("NumeroComprobante", TypeName = "varchar(25)")]
        public string? NumeroComprobante { get; set; }

        public DateTime? Fecha { get; set; }

        [Precision(10, 4)]
        public decimal SubTotal { get; set; }

        [Precision(10, 4)]
        public decimal Iva { get; set; }

        [Precision(10, 4)]
        public decimal Total { get; set; }

        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Cliente? Cliente { get; set; }

        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuario? Usuario { get; set; }
    }
}
