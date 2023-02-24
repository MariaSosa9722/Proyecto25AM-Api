using Domain.Dto;
using Domain.Entities;
using Proyecto25AM.Context;
using Proyecto25AM.Services.IServices;

namespace Proyecto25AM.Services.Services
{
    public class UsuarioServices : IUsuarioServices
    {

        private readonly ApplicatioDBContext _context;
        public UsuarioServices(ApplicatioDBContext context)
        {
            _context = context;
        }


        //Creacion de funciones CRUD

        public async Task< UsuarioResponse> CrearUsuario(UsuarioResponse request)
        {

            try
            {
                Usuario user = new Usuario()
                {
                    User = request.User,
                    Password = request.Password,
                    FechaRegistro = request.FechaRegistro,
                    FkEmpleado = request.FkEmpleado,
                    FkRol = request.FkRol

                };

                _context.Usuarios.Add(user);
                _context.SaveChangesAsync();


                return request;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocurrio un error "+ex.Message);
            }

        }





    }
}
