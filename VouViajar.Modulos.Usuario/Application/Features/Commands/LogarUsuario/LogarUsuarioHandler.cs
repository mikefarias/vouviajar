using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using VouViajar.Modulos.Usuarios.Domain.Services.Interfaces;
using VouViajar.Modulos.Usuarios.Domain.Services.ViewModel;

namespace VouViajar.Modulos.Usuarios.Application.Features.Commands.LogarUsuario
{
    public class LogarUsuarioHandler : IRequestHandler<LogarUsuarioCommand, LoginResponseViewModel>
    {

        private readonly IUsuarioService _usuarioService;

        public LogarUsuarioHandler(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService ?? throw new ArgumentNullException(nameof(usuarioService));
        }

        public async Task<LoginResponseViewModel> Handle(LogarUsuarioCommand request, CancellationToken cancellationToken)
        {
            var retorno = await _usuarioService.LogarUsuarioAsync(request.Email, request.Password, request.IsPersistent, request.LockoutOnFailure);

            return await Task.FromResult<LoginResponseViewModel>(retorno);
        }

    }
}
