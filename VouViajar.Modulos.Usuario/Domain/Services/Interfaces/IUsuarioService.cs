using System.Threading.Tasks;
using VouViajar.Modulos.Usuarios.Domain.Entities.Agreggates;
using VouViajar.Modulos.Usuarios.Domain.Services.ViewModel;

namespace VouViajar.Modulos.Usuarios.Domain.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task<LoginResponseViewModel> RegistrarUsuarioAsync(Usuario usuario, string password);
        Task<LoginResponseViewModel> LogarUsuarioAsync(string email, string password, bool isPersistent, bool bockoutOnFailure);
    }
}
