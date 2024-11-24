using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal.Modelos
{
    public class Producto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del producto es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El tipo del producto es requerido")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string? Tipo { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "El stock debe ser un numero positivo")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Stock { get; set; }
        [Required(ErrorMessage = "La unidad de medida es requerida")]
        [StringLength(20,ErrorMessage = "Máximo 20 caracteres")]
        public string? Unidad { get; set; }
        public int PedidosId { get; set; }
        virtual public Pedido? Pedido  { get;set; }
        virtual public ICollection<Categoria> Categorias { get; set; }

    }
}
