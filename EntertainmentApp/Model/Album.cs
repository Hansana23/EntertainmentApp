using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntertainmentApp.Model
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }

        [Column (TypeName ="nvarchar(100)")]
        public string AlbumName { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string Artist { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string AlbumType { get; set; } = "";

        public int GenreId { get; set; }
        public Genre Genere { get; set; }

    }
}
