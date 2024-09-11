using System.ComponentModel.DataAnnotations;
using TiendaOnline.Models.Enums;

namespace TiendaOnline.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Usuario Usuario { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(255, ErrorMessage = "El Comentario {0} Debe tener un maximo de {1} caracteres")]
        public string Comment { get; set; } = null;
        public StatusOrder StatusOrder{ get; set; }

        public ICollection<DataSale> DataSale { get; set; }
        public int Amount => DataSale == null ? 0 : DataSale.Sum(sd => sd.Amount);

        [DisplayFormat(DataFormatString = "0:C2")]
        [Display(Name = "Total")]

        public decimal Total => DataSale == null ? 0 : DataSale.Sum(sd => sd.Total);

    }
}
