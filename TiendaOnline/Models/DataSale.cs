using System.ComponentModel.DataAnnotations;

namespace TiendaOnline.Models
{
    public class DataSale
    {
        public int Id { get; set; }
        public Venta Venta { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(200, ErrorMessage ="El comentario no puede tener mas de 200 Caracteres")]

        public string Comment { get; set; }

        public Producto Producto { get; set; }
        
        public int  Amount { get; set; }

        [DisplayFormat(DataFormatString ="0:C2")]
        public decimal Total => Producto == null ? 0 : (decimal)Amount* Producto.Price;
    }
}