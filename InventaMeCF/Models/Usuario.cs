using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InventaMeCF.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [Required(ErrorMessage = "El correo es obligatorio")]
        [Column("Correo", TypeName = "varchar(20)")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [Column("Password", TypeName = "varchar(64)")]
        public string Password { get; set; }
        public int RolAsigandoId { get; set; }

        [ForeignKey("RolAsigandoId")]
        public virtual RolAsignad RolAsignad { get; set; }
    }
}
