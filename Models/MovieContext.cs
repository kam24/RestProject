using Microsoft.EntityFrameworkCore;

namespace REST.Models
{
    public class MovieContext: DbContext
    {
        public DbSet<Movie> Movies { get; set; } = null!;

        public MovieContext(DbContextOptions<MovieContext> options) 
            : base(options) { }

    }
}
