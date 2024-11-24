using ProyectoFinal.Modelos;
namespace ProyectoFinal.Repositorio
{
    public interface IRepositorioProductos
    {
        Task<List<Producto>> GetAll();
        Task<Producto?> Get(int id);
        Task<List<Pedido>> GetPedidos();
        Task<List<Categoria>> GetCategorias();
        Task<Producto> Add(Producto producto);
        Task Update(int id, Producto producto);
        Task Delete(int id);  
    }
}
