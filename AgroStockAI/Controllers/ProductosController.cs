using Microsoft.AspNetCore.Mvc;

namespace AgroStockAI.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}