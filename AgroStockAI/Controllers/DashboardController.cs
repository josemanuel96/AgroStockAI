using Microsoft.AspNetCore.Mvc;

namespace AgroStockAI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}