using Domain.Dto;

namespace Proyecto25AM.Services.IServices
{
    public interface IUsuarioServices
    {


        public Task<UsuarioResponse> CrearUsuario(UsuarioResponse request);


    }
}
