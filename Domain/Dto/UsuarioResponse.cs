using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto
{
    public class UsuarioResponse
    {

        public string User { get; set; }
        public string Password { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? FkEmpleado { get; set; }
        public int? FkRol { get; set; }






    }
}
