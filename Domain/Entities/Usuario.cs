using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Usuario
    {
        [Key]
        public int PkUsuario { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public DateTime FechaRegistro { get; set; }

        [ForeignKey("Empleado")]
        public int? FkEmpleado { get; set; }
        [ForeignKey("Rol")]
        public int? FkRol { get; set; }
        public Empleado Empleado { get; set; }
        public Rol Rol { get; set; }    
    }
}
