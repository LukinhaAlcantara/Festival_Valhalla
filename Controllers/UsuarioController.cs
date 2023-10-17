using Festival_Valhalla.Data;
using Festival_Valhalla.Models;
using Microsoft.AspNetCore.Mvc;

namespace Festival_Valhalla.Controllers
{
    public class UsuarioController : Controller
    {
        readonly private ApplicationDbContext _db;

        public UsuarioController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index(UsuarioModel usuario)
        {
            if (ModelState.IsValid)
            {
                _db.Usuarios.Add(usuario);
                _db.SaveChanges();
                TempData["Menssagem de sucesso"] = "Cadastro realizado com sucesso!";
                return RedirectToAction("Index");
            }

            return View();
        }

    }
}
