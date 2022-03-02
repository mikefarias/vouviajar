using System.Threading.Tasks;
using VouViajar.Modulos.Usuarios.Domain.Entities.Agreggates;
using VouViajar.Modulos.Usuarios.Domain.Services.Interface;
using VouViajar.Modulos.Usuarios.Domain.Services.Interfaces;

namespace VouViajar.Modulos.Usuarios.Domain.Services
{
    public class UsuarioAgenciaService : BaseService, IUsuarioAgenciaService
    {
        private readonly INotificador _notificador;
        public UsuarioAgenciaService(INotificador notificador) : base (notificador)
        {
            _notificador = notificador;
        }

        public async Task<ResponseService> RegistrarAgencia(Usuario usuario)
        {
            return await GenerateSuccessServiceResponse();
        }
    }
}
