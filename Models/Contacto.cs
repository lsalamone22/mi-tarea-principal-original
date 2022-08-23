using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace webapp.Models
{
    public class Contacto
    {
        [Display(Name = "Nombre Completo")]
        public string? Name {get; set; }

        [EmailAddress]
        [Display(Name = "Correo", Prompt = "example@example.org")]
        public string? Email {get; set; }

        [Phone]
        [Display(Name = "Telefono")]
        public string? Phone {get; set; }

        [MinLength(5)]
        [MaxLength(1024)]
        [Display(Name = "Comentario")]
        public string? Description {get; set; }

    }
}