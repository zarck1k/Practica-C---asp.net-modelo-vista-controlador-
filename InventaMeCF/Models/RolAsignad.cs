namespace InventaMeCF.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    public class RolAsignad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int RolId { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuario Usuario { get; set; }
        [ForeignKey("RolId")]
        public virtual Rol Rol { get; set; }
    }
}
