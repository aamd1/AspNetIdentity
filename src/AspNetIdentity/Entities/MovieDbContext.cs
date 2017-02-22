using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetIdentity.Entities
{
    public class MoviesDbContext : IdentityDbContext<User>
    {
        public MoviesDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
