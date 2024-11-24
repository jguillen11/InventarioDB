namespace ProyectoFinal.Modelos
{
    public class Categoria
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        virtual public ICollection<Producto> Productos { get; set; }
    }
}
