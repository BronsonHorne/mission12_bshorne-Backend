using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Model;

namespace MoviesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private MovieDbContext context;
        public MovieController(MovieDbContext temp) {
            context = temp;

        }
        public IEnumerable<Movies> Get()
        {
            var x = context.Movies.ToArray();

            return x;
        }
    }
}
