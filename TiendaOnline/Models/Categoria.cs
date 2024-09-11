using System.ComponentModel.DataAnnotations;

namespace TiendaOnline.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [MaxLength(100, ErrorMessage ="Nombre Debe tener {0} maximo {1} caracter ")]
        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        public string Name { get; set; }
    }
}
