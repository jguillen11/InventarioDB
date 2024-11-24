using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Modelos;
namespace ProyectoFinal.Repositorio
{
    public class RepositorioProductos : IRepositorioProductos
    {
        private readonly InventarioDBContext _context;
        public RepositorioProductos(InventarioDBContext context)
        {
            _context = context;
        }
        public async Task<Producto> Add(Producto producto)
        {
            await _context.Productos.AddAsync(producto);
            await _context.SaveChangesAsync();
            return producto;
        }
        public async Task Delete(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<Producto?> Get(int id)
        {
            return await _context.Productos.FindAsync(id);
        }
        public async Task<List<Producto>> GetAll()
        {
            return await _context.Productos.ToListAsync();
        }

        public async Task<List<Pedido>> GetPedidos()
        {
            return await _context.Pedidos.ToListAsync();
        }

        public async Task<List<Categoria>> GetCategorias()
        {
            return await _context.Categorias.ToListAsync();
        }
        public async Task Update(int id, Producto producto)
        {
            var productoactual = await _context.Productos.FindAsync(id);
            if (productoactual != null)
            {
                productoactual.Nombre = producto.Nombre;
                productoactual.Tipo = producto.Tipo;
                productoactual.Stock = producto.Stock;
                productoactual.Unidad = producto.Unidad;
                await _context.SaveChangesAsync();
            }
        }
    }
}

