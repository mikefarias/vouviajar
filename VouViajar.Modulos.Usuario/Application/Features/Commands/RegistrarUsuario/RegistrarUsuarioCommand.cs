using MediatR;
using VouViajar.Modulos.Usuarios.Domain.Services.ViewModel;

namespace VouViajar.Modulos.Usuarios.Application.Features.Commands.RegistrarUsuario
{
    public class RegistrarUsuarioCommand : IRequest<LoginResponseViewModel>
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
