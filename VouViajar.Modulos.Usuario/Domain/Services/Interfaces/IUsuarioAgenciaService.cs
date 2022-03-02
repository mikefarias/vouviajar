using System.Threading.Tasks;
using VouViajar.Modulos.Usuarios.Domain.Entities.Agreggates;

namespace VouViajar.Modulos.Usuarios.Domain.Services.Interfaces
{
    public interface IUsuarioAgenciaService
    {
        Task<ResponseService> RegistrarAgencia(Usuario usuario);
    }
}
