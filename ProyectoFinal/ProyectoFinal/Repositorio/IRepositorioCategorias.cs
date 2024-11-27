using ProyectoFinal.Modelos;
namespace ProyectoFinal.Repositorio
{
    public interface IRepositorioCategorias
    {
        Task<List<Categoria>> GetAll();
        Task<Categoria?> Get(int id);
        Task<Categoria> Add(Categoria categoria);
        Task Update(int id, Categoria categoria);
        Task Delete(int id);
    }
}
