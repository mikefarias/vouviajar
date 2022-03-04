using MediatR;
using System.Threading.Tasks;
using VouViajar.Modulos.Usuarios.Domain.Entities.Agreggates;

namespace VouViajar.Modulos.Usuarios.Domain.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task<Unit> RegistrarUsuarioAsync(Usuario usuario, string password);
    }
}
