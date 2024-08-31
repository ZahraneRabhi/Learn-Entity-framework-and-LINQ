using Microsoft.EntityFrameworkCore;
using LearnLinq.Models;

namespace LearnLinq.Data
{
    /// <summary>
    /// Represents the database context for the app
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppDbContext"/> class
        /// </summary>
        /// <param name="options">The options to be used by a <see cref="DbContext"/></param>
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } 

        /// <summary>
        /// Gets or sets the <see cref="DbSet{TEntity}"/> of heroes
        /// </summary>
        public DbSet<Hero> Heroes { get; set; }
    }
}
