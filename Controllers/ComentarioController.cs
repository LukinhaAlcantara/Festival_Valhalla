using Festival_Valhalla.Data;
using Festival_Valhalla.Models;
using Microsoft.AspNetCore.Mvc;

namespace Festival_Valhalla.Controllers
{
    public class ComentarioController : Controller
    {
            readonly private ApplicationDbContext _db;

            public ComentarioController(ApplicationDbContext db)
            {
                _db = db;
            }
        [HttpPost]
        public IActionResult Comentar(string comentario)
        {
            ComentarioModel comet = new ComentarioModel();
            comet.Comentario = comentario;
            
            if (comet != null)
            {
                _db.Comentarios.Add(comet);
                _db.SaveChanges();
                TempData["MensagemSucesso"] = "Cadastro realizado com sucesso!";
                    return RedirectToAction("Index", "Albuns") ;
            }

                return RedirectToAction("Index", "Albuns");


            }
        }
    }

