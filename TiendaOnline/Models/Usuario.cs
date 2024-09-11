using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using TiendaOnline.Models.Enums;

namespace TiendaOnline.Models
{
    public class Usuario: IdentityUser
    {
        public int IdUser { get; set; }

        [MaxLength(100, ErrorMessage ="el nombre de usuario {0} debe tener como maximo {1} caracteres")]
        [Required(ErrorMessage ="El nombre de usuario es obligatorio")]
        public string NameUser { get; set; }

        [Display(Name ="Foto")]

        public string UrlPhotoUser { get; set; }

        public TipoUsuarios tipoUsuarios { get; set; }

    }
}
