using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiMovies.Models;

namespace ApiMovies.Data
{
    public class ApiMoviesContext : DbContext
    {
        public ApiMoviesContext (DbContextOptions<ApiMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<ApiMovies.Models.Movie> Movie { get; set; } = default!;
        public DbSet<ApiMovies.Models.User> User { get; set; } = default!;
    }
}
