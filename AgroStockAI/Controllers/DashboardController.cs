using AgroStockAI.Data;
using AgroStockAI.Filters;
using AgroStockAI.Models;
using AgroStockAI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgroStockAI.Controllers
{
    [VerificarSesion]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;

        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var modelo = new DashboardViewModel
            {
                TotalProductos = _context.Productos.Count(),
                TotalCategorias = _context.Categorias.Count(),
                TotalMovimientos = _context.MovimientosInventario.Count(),
                TotalAlertasActivas = _context.Alertas.Count(a => a.Activa),


                UltimosMovimientos = _context.MovimientosInventario
                    .Include(m => m.Producto)
                    .OrderByDescending(m => m.Fecha)
                    .Take(5)
                    .ToList()
            };

            return View(modelo);
        }
    }
}