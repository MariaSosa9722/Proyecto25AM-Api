using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Factura
    {
        [Key]
        public int PkFactura { get; set; }
        [Required]
        public string RazonSocial { get; set; }
        [Required]
        public string Fecha { get; set; }
        [Required]
        public string RFC { get; set; }

        [ForeignKey("Cliente")]
        public int FkCliente { get; set; }  
       
        public Cliente Cliente { get; set; }    
    }
}
