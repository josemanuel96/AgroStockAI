using AgroStockAI.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AgroStockAI.Controllers
{
    [VerificarSesion]
    public class InventarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}