using MediatR;
using VouViajar.Modulos.Usuarios.Domain.Services.ViewModel;

namespace VouViajar.Modulos.Usuarios.Application.Features.Commands.LogarUsuario
{
    public class LogarUsuarioCommand : IRequest<LoginResponseViewModel>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsPersistent { get; set; }
        public bool LockoutOnFailure { get; set; }


}
}
