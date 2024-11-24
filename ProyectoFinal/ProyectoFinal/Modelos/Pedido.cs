namespace ProyectoFinal.Modelos
{
    public class Pedido
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        virtual public ICollection<Producto>? Productos { get; set; }
    }
}
