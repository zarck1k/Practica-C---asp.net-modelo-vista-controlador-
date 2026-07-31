using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InventaMeCF.Models;

public class UnidadMedidasController : Controller
{
    private readonly InventaMeCFContext _context;

    public UnidadMedidasController(InventaMeCFContext context)
    {
        _context = context;
    }

    // GET: UNIDADMEDIDAS
    public async Task<IActionResult> Index()
    {
        return View(await _context.UnidadMedidas.ToListAsync());
    }

    // GET: UNIDADMEDIDAS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var unidadmedida = await _context.UnidadMedidas
            .FirstOrDefaultAsync(m => m.Id == id);
        if (unidadmedida == null)
        {
            return NotFound();
        }

        return View(unidadmedida);
    }
}