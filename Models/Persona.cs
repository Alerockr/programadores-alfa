using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoWEBCOVID.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Identificacion es obligatorio")]
        //[StringLength(100,ErrorMessage ="El {0} debe ser al menos {2} y maximo {1} carateres", MinimumLength =3)]
        [Display(Name ="Identificacion")]
        public int Identificacion { get; set; }

        [Required(ErrorMessage = "Campo Nombre es obligatorio")]
        //[StringLength(100, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} carateres", MinimumLength = 3)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo Apellido es obligatorio")]
        //[StringLength(100, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} carateres", MinimumLength = 3)]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Campo Fecha de ingreso es obligatorio")]
        [Display(Name = "Fecha de ingreso")]
        public DateTime FechaIngreso { get; set; }

        [Required(ErrorMessage = "Campo Rol es obligatorio")]
        [Display(Name = "Rol")]
        //[StringLength(100,ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} carateres", MinimumLength = 3)]
        public string Rol { get; set; }



    }
}
