using Microsoft.EntityFrameworkCore;

namespace MoviesAPI.Model
{
    public class MovieDbContext :DbContext
    {
        public MovieDbContext (DbContextOptions<MovieDbContext> options): base(options) { }

        public DbSet<Movies> Movies { get; set; }
    }
}
