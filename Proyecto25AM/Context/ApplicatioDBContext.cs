using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Proyecto25AM.Context
{
    public class ApplicatioDBContext : DbContext
    {
        public ApplicatioDBContext(DbContextOptions options) : base(options)
        {

        }

        //Modelos
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Puesto> Puestos { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
 

    }
}
