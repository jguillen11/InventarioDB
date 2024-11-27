using ProyectoFinal.Modelos;
namespace ProyectoFinal.Repositorio
{
    public interface IRepositorioPedidos
    {
        Task<List<Pedido>> GetAll();
        Task<Pedido?> Get(int id);
        Task<Pedido> Add(Pedido pedido);
        Task Update(int id, Pedido pedido);
        Task Delete(int id);
    }
}
