using Festival_Valhalla.Models;
using Microsoft.EntityFrameworkCore;

namespace Festival_Valhalla.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<AlbumModel> Albuns { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<ComentarioModel> Comentarios { get; set; }
    }
}
