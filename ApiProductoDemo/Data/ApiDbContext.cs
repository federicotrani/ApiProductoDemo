using ApiProductoDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiProductoDemo.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
