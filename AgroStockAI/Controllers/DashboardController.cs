using AgroStockAI.Filters;
using Microsoft.AspNetCore.Mvc;

namespace AgroStockAI.Controllers
{
    [VerificarSesion]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}