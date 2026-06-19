using Microsoft.AspNetCore.Mvc;

namespace AgroStockAI.Controllers
{
    public class InventarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}