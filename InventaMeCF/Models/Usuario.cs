using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InventaMeCF.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("Nombre", TypeName = "varchar(80)")]
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(80, ErrorMessage = "El nombre del usuario debe tener una longitud mínima de 3 caracteres y como máximo 80",
            MinimumLength = 3)]
        public string? Nombre { get; set; }

        [Column("Correo", TypeName = "varchar(100)")]
        [Required(ErrorMessage = "El correo es obligatorio.")]
        [StringLength(100, ErrorMessage = "El correo debe tener entre 10 y 100 caracteres",
            MinimumLength = 10)]
        public string? Correo { get; set; }

        [Required(ErrorMessage = "La clave es obligatoria")]
        [Column("Clave", TypeName = "varchar(64)")]
        public string? Clave { get; set; }
        public virtual ICollection<RolAsignado> RolesAsignados { get; set; }
    }
}
