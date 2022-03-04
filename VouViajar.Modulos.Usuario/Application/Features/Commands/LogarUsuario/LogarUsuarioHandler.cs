using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace VouViajar.Modulos.Usuarios.Application.Features.Commands.LogarUsuario
{
    public class LogarUsuarioHandler : IRequestHandler<LogarUsuarioCommand>
    {
        public Task<Unit> Handle(LogarUsuarioCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
