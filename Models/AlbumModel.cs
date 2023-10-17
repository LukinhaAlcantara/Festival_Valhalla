using System.ComponentModel.DataAnnotations.Schema;

namespace Festival_Valhalla.Models
{
    public class AlbumModel
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public int Ano { get; set; }
        public string CoverUrl { get; set; }
        public int Likes { get; set; }
        [ForeignKey("ComentarioModel")]
        public int? ComentarioId { get; set; }
        public ComentarioModel? Comentario { get; set; }

    }
}
