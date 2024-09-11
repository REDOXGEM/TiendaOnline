using System.ComponentModel.DataAnnotations;

namespace TiendaOnline.Models
{
    public class VentaTemporal
    {
        public int Id { get; set; }

        public Usuario Usuario { get; set; }

        public Producto Producto { get; set; }

        public int Amount { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(300, ErrorMessage = "El comentario {0} debe tener como maximo {1} caracteres")]
        public string Comment { get; set; } = null;

        [DisplayFormat(DataFormatString = "{0:c2}")]
        public decimal Total => Producto == null ? 0 : (decimal)Amount * Producto.Price;
    }
}
