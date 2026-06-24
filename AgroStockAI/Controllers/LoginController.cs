using AgroStockAI.Filters;
using AgroStockAI.Data;
using AgroStockAI.Models;
using Microsoft.AspNetCore.Mvc;


public class LoginController : Controller
{
    private readonly AppDbContext _context;

    public LoginController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(Usuario user)
    {
        if (ModelState.IsValid)
        {
            _context.Usuarios.Add(user);
            _context.SaveChanges();

            HttpContext.Session.SetString("Usuario", user.Nombre);

            return RedirectToAction("Index", "Dashboard");
        }

        return View(user);
    }

    [HttpPost]
    public IActionResult Login(string email, string password)
    {
        var user = _context.Usuarios
            .FirstOrDefault(u => u.Email == email && u.Password == password);

        if (user != null)
        {
            HttpContext.Session.SetString("Usuario", user.Nombre);
            return RedirectToAction("Index", "Dashboard");
        }

        ViewBag.Error = "Credenciales incorrectas";
        return View("Index");
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index", "Login");
    }
}