using ClosedXML.Excel;
using InventaMeCF.Models;
using InventaMeCF.Utilidades;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;


namespace InventaMeCF.Controllers
{

    [Authorize(Roles = "Administrador")]
    public class ProductoController : Controller
    {
        private readonly InventaMeCFContext _context;

        public ProductoController(InventaMeCFContext context)
        {
            _context = context;
        }


        [HttpPost]
        public FileResult ExportarXLSX()
        {
            long id = Convert.ToInt32(Request.Form["id"]);
            using (XLWorkbook wb = new XLWorkbook())
            {
                var productos = _context.Productos.ToList();

                IXLWorksheet ws = wb.Worksheets.Add();

                ws.Range("A1").Value = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                ws.Range("A1").Style.Font.Bold = true;
                ws.Range("A1").Style.Font.FontSize = 14;
                ws.Range("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                ws.Range("A1:D1").Merge();
                ws.Range("A3").Value = "ID";
                ws.Range("A3").Style.Font.Bold = true;
                ws.Range("B3").Value = "NOMBRE";
                ws.Range("B3").Style.Font.Bold = true;
                ws.Range("C3").Value = "PRECIO";
                ws.Range("C3").Style.Font.Bold = true;
                ws.Range("D3").Value = "EXISTENCIA";
                ws.Range("D3").Style.Font.Bold = true;

                int row = 4;
                foreach (Producto item in productos)
                {
                    ws.Cell(row, 1).Value = item.Id;
                    ws.Cell(row, 2).Value = item.Nombre;
                    ws.Cell(row, 3).Value = item.PrecioUnitario;
                    ws.Cell(row, 3).Style.NumberFormat.Format = "#,##0.00";
                    ws.Cell(row, 4).Value = item.MarcaId;
                    row++;
                }
                ws.Column(1).AdjustToContents();
                ws.Column(2).AdjustToContents();
                ws.Column(3).AdjustToContents();
                ws.Column(4).AdjustToContents();
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Productos.xlsx");
                }
            }
        }
        public async Task<IActionResult> Index(
       int? productoMarca,
       string cadenaString,
       int pg = 1)
        {
            if (_context.Productos == null)
            {
                return Problem("El conjunto 'InventaMeCFContext.Productos' está vacío.");
            }

            IQueryable<Marca> marcaQuery =
                from m in _context.Marcas
                select m;

            var productos =
                from m in _context.Productos
                select m;

            if (!string.IsNullOrEmpty(cadenaString))
            {
                productos = productos.Where(s =>
                    s.Nombre!.ToUpper().Contains(cadenaString.ToUpper()));
            }

            if (productoMarca.HasValue && productoMarca != 0)
            {
                productos = productos.Where(x =>
                    x.Marca!.Id == productoMarca);
            }

            // Total de productos después de aplicar los filtros
            var totalProductos = await productos.CountAsync();

            // Crear paginación
            var paginacion = new Paginacion(
                totalProductos,
                pg,
                5,
                "Producto"
            );

            // Obtener solamente los productos de la página actual
            var productosPaginados = await productos
                .Skip(paginacion.Salto)
                .Take(paginacion.RegistrosPagina)
                .ToListAsync();

            // Crear ViewModel
            var productoMarcaVM = new ProductoMarcaModelView
            {
                Marcas = new SelectList(marcaQuery, "Id", "Name"),
                Productos = productosPaginados
            };

            ViewBag.Paginacion = paginacion;

            return View(productoMarcaVM);
        }
    }
}