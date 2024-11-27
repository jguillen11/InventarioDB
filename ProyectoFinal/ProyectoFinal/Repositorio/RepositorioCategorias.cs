using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Modelos;
namespace ProyectoFinal.Repositorio
{
    public class RepositorioCategorias : IRepositorioCategorias
    {
        private readonly InventarioDBContext _context;
        public RepositorioCategorias(InventarioDBContext context)
        {
            _context = context;
        }
        public async Task<Categoria> Add(Categoria categoria)
        {
            await _context.Categorias.AddAsync(categoria);
            await _context.SaveChangesAsync();
            return categoria;
        }
        public async Task Delete(int id)
        {
            var categoria = await _context.Categorias.FindAsync(id);
            if (categoria != null)
            {
                _context.Categorias.Remove(categoria);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<Categoria?> Get(int id)
        {
            return await _context.Categorias.FindAsync(id);
        }
        public async Task<List<Categoria>> GetAll()
        {
            return await _context.Categorias.Include(p => p.Productos).ToListAsync();
        }
        public async Task Update(int id, Categoria categoria)
        {
            var categoriaactual = await _context.Categorias.FindAsync(id);
            if (categoriaactual != null)
            {
                categoriaactual.Nombre = categoria.Nombre;
                categoriaactual.Productos = categoria.Productos;
                await _context.SaveChangesAsync();
            }
        }
    }
}

