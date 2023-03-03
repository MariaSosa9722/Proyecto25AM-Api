using Domain.Dto;
using Domain.Entities;

namespace Proyecto25AM.Services.IServices
{
    public interface IUsuarioServices
    {

        public Task<Response<List<Usuario>>> GetUsers();
        public Task<Response<Usuario>> CrearUsuario(UsuarioResponse request);


    }
}
