namespace InventaMeCF.Models
    using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
{
    public class Rol
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
