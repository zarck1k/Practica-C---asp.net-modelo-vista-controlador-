using Microsoft.AspNetCore.Mvc.Rendering;

namespace InventaMeCF.Models
{
    public class ProductoMarcaModelView
    {
        public List<Producto> Productos { get; set; } = new();

        public SelectList Marcas { get; set; } = default!;

        public int? ProductoMarca { get; set; }

        public string? CadenaString { get; set; }

    }
}
