using Microsoft.EntityFrameworkCore;

namespace MovieWebApp.Data
{
    public class MovieContext:DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options): base(options) {}
        public DbSet<Models.Movie> Movie{ get; set; } 
    }
}