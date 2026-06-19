using Microsoft.AspNetCore.Mvc;

namespace AgroStockAI.Controllers
{
    public class AlertasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}