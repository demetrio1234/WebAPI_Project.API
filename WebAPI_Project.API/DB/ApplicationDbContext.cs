using Microsoft.EntityFrameworkCore;
using WebAPI_Project.API.Models.Domain;

namespace WebAPI_Project.API.DB {
    public class ApplicationDbContext : DbContext {

        /// <summary>
        /// It passes the as parameter taken DbContextOptions options and passes
        /// it to its base class
        /// </summary>
        /// <param name="options"></param>

        public ApplicationDbContext(DbContextOptions options) : base(options) {
        }

        public DbSet<BlogItem> BlogItems { get; set; }

        public DbSet<Category> Categories { get; set; }





    }
}
