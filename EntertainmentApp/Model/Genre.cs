using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntertainmentApp.Model
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Genre_Name { get; set; } = "";
    }
}
