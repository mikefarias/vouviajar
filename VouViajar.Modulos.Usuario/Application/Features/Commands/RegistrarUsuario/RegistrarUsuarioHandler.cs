using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using VouViajar.Modulos.Usuarios.Domain.Entities.Agreggates;
using VouViajar.Modulos.Usuarios.Domain.Services.Interfaces;
using VouViajar.Modulos.Usuarios.Domain.Services.ViewModel;

namespace VouViajar.Modulos.Usuarios.Application.Features.Commands.RegistrarUsuario
{
    public class RegistrarUsuarioHandler : IRequestHandler<RegistrarUsuarioCommand, LoginResponseViewModel>
    {

        private readonly IUsuarioService _usuarioService;

        public RegistrarUsuarioHandler(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService ?? throw new ArgumentNullException(nameof(usuarioService));
        }

        public async Task<LoginResponseViewModel> Handle(RegistrarUsuarioCommand request, CancellationToken cancellationToken)
        {
            var usuario = new Usuario
            {
                UserName = request.UserName,
                Email = request.Email,
                EmailConfirmed = request.EmailConfirmed
            };

            var loginResponse = await _usuarioService.RegistrarUsuarioAsync(usuario, request.Password);

            return await Task.FromResult<LoginResponseViewModel>(loginResponse);
        }
    }
}