using Microsoft.AspNetCore.Mvc;

namespace AgroStockAI.Controllers
{
    public class CategoriasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}