using Microsoft.EntityFrameworkCore;

namespace EntertainmentApp.Model
{
    public class AlbumDbContext : DbContext
    {
        public AlbumDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
