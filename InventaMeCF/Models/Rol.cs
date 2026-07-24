using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventaMeCF.Models
{
    public class Rol
    {
        
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            [Column("Nombre", TypeName = "varchar(50)")]
            [DisplayName("Nombre del rol")]
            [Required(ErrorMessage = "El nombre del rol es requerido.")]
            [StringLength(50, ErrorMessage = "El nombre del rol debe tener una longitud mínima de 3 caracteres y como máximo 50",
                MinimumLength = 3)]
            public string? Nombre { get; set; }
           public virtual ICollection<RolAsignado> RolesAsignados { get; set; }
        
    }
}
