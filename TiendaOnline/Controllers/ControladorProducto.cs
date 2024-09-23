using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TiendaOnline.Data;

namespace TiendaOnline.Controllers
{
    public class ControladorProducto : Controller
    {
        private readonly TiendaOnlineContext _context;

        public ControladorProducto(TiendaOnlineContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Lista()
        {
            return View(await _context.Productos.Include(e => e.Categoria).ToListAsync());
        }

    }
}
