using System.Threading.Tasks;
using Vouviajar.API.Autenticacao.Entities;

namespace Vouviajar.API.Autenticacao.Services.Interfaces
{
    public interface IUsuarioAgenciaService
    {
        Task<ResponseService> RegistrarAgencia(Usuario usuario);
    }
}
