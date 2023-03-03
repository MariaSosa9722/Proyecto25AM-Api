using Domain.Dto;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Proyecto25AM.Context;
using Proyecto25AM.Services.IServices;

namespace Proyecto25AM.Services.Services
{
    public class UsuarioServices : IUsuarioServices
    {

        private readonly ApplicatioDBContext _context;
        public string Mensaje;
        public UsuarioServices(ApplicatioDBContext context)
        {
            _context = context;
        }


        //Creacion de funciones CRUD

        public async Task<Response<List<Usuario>>> GetUsers()
        {
            try
            {
              
               
                var response = await _context.Usuarios.ToListAsync();

                if (response.Count > 0)
                {
            
                    return new Response<List<Usuario>>(response);

                }
                else
                {
                    Mensaje = "No se encontro ningun registro";
                    return new Response<List<Usuario>>(Mensaje);
                }



            }
            catch (Exception ex)
            {

                throw new Exception("Surgio un error: "+ex.Message);
            }

        }


        public async Task<Response<Usuario>> CrearUsuario(UsuarioResponse request)
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
                await _context.SaveChangesAsync();


                return new Response<Usuario>(user);
            }
            catch (Exception ex)
            {

                throw new Exception("Ocurrio un error "+ex.Message);
            }

        }





    }
}
