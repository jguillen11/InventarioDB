using Microsoft.EntityFrameworkCore;
namespace ProyectoFinal.Modelos
{
    public class InventarioDBContext : DbContext
    {
        public InventarioDBContext(DbContextOptions<InventarioDBContext> options) : base(options)
        {
        }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
