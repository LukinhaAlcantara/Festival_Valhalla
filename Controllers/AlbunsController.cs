using Festival_Valhalla.Data;
using Festival_Valhalla.Models;
using Microsoft.AspNetCore.Mvc;

namespace Festival_Valhalla.Controllers
{
    public class AlbunsController : Controller
    {
        readonly private ApplicationDbContext _db;

        public AlbunsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<AlbumModel> album = _db.Albuns;
            IEnumerable<ComentarioModel> coment = _db.Comentarios;
            return View(album);
        }
    }
}
