using InventaMeCF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;


namespace InventaMeCF.Controllers
{
    public class ProductoController : Controller
    {
        private readonly InventaMeCFContext _context;

        public ProductoController(InventaMeCFContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? productoMarca, string cadenaString)
        {
            if (_context.Productos == null)
            {
                return Problem("El conjunto 'InventaMeCFContext.Productos'  está vacío.");
            }

            // Use LINQ to get list of genres.
            IQueryable<Marca> marcaQuery = from m in _context.Marcas select m;
            var productos = from m in _context.Productos select m;

            if (!string.IsNullOrEmpty(cadenaString))
            {
                productos = productos.Where(s => s.Nombre!.ToUpper().Contains(cadenaString.ToUpper()));
            }

            if (productoMarca.HasValue && productoMarca != 0)
            {
                productos = productos.Where(x => x.Marca!.Id == productoMarca);
            }

            var productoMarcaVM = new ProductoMarcaModelView
            {
                Marcas = new SelectList(marcaQuery, "Id", "Name"),
                Productos = await productos.ToListAsync()
            };

            return View(productoMarcaVM);
        }
    }
}