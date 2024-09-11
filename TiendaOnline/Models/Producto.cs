using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaOnline.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = "Nombre del Producto Debe tener {0} maximo {1} caracter ")]
        [Required(ErrorMessage = "El campo {0} debe completarce")]

        public string NameProduct { get; set; }

        [Column(TypeName ="decimal(18,2)")]//declara el formato de la columna con 2 decimales 
        [Required(ErrorMessage = "El campor {0} es obligatorio")]

        public decimal Price { get; set; }

        [Required(ErrorMessage = "El campo {0} debe completarce")]
        public int Inventory { get; set; }

        [DataType(DataType.MultilineText)]//Formato que permite que se abarque mayor cantidad de caracteres
        [MaxLength(650, ErrorMessage = "El campo {0} puede posser maximo de caracteres {1}")]

        public string Description { get; set; } = null;

        [Display(Name ="Foto")]

        public string UrlPhoto { get; set; }

        public   Categoria Categoria { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Se debe seleccionar uan categoria")]

        public int IdCategoria { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> Categorias { get; set; }



      

    }
}
