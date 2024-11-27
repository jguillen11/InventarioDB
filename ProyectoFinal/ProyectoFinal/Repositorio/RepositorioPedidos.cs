using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Modelos;
namespace ProyectoFinal.Repositorio
{
    public class RepositorioPedidos : IRepositorioPedidos
    {
        private readonly InventarioDBContext _context;
        public RepositorioPedidos(InventarioDBContext context)
        {
            _context = context;
        }
        public async Task<Pedido> Add(Pedido pedido)
        {
            await _context.Pedidos.AddAsync(pedido);
            await _context.SaveChangesAsync();
            return pedido;
        }
        public async Task Delete(int id)
        {
            var pedido = await _context.Pedidos.FindAsync(id);
            if (pedido != null)
            {
                _context.Pedidos.Remove(pedido);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<Pedido?> Get(int id)
        {
            return await _context.Pedidos.FindAsync(id);
        }
        public async Task<List<Pedido>> GetAll()
        {
            return await _context.Pedidos.Include(p => p.Productos).ToListAsync();
        }
        public async Task Update(int id, Pedido pedido)
        {
            var pedidoactual = await _context.Pedidos.FindAsync(id);
            if (pedidoactual != null)
            {
                pedidoactual.Nombre = pedido.Nombre;
                pedidoactual.Productos = pedido.Productos;
                await _context.SaveChangesAsync();
            }
        }
    }
}

