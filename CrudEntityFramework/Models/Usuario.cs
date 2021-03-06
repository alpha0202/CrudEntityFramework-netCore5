using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEntityFramework.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public int Nombre { get; set; }


        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        [Display(Name ="Teléfono")]
        public int Telefono { get; set; }


        [Required(ErrorMessage = "El celular es obligatorio.")]
        public int Celular { get; set; }


        [Required(ErrorMessage = "El email es obligatorio.")]
        [EmailAddress]
        public int Email { get; set; }
    }
}
