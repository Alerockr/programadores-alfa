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
        public int Id{ get; set; }

        [Required(ErrorMessage ="Campo Identificacion es obligatorio")]
        [StringLength(50,ErrorMessage ="El {0} debe ser al menos {2} y maximo {1} carateres", MinimumLength =3)]
        public int Identificacion { get; set; }

        [Required(ErrorMessage = "Campo Identificacion es obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} carateres", MinimumLength = 3)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo Identificacion es obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} carateres", MinimumLength = 3)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Campo Identificacion es obligatorio")]
        public DateTime FechaIngreso { get; set; }

        [Required(ErrorMessage = "Campo Identificacion es obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} carateres", MinimumLength = 3)]
        public string Rol { get; set; }



    }
}
