using MediatR;
using System.Threading;
using System.Threading.Tasks;
using VouViajar.Modulos.Usuarios.Domain.Entities.Agreggates;

namespace VouViajar.Modulos.Usuarios.Application.Features.Commands.RegistrarUsuario
{
    public class RegistrarUsuarioHandler : IRequestHandler<RegistrarUsuarioCommand>
    {

        public async Task<Unit> Handle(RegistrarUsuarioCommand request, CancellationToken cancellationToken)
        {
            var usuario = new Usuario
            { 
                UserName = request.UserName, 
                Email = request.Email, 
                EmailConfirmed = request.EmailConfirmed
            };
            
            return await Task.FromResult(Unit.Value); 
        }
    }
}