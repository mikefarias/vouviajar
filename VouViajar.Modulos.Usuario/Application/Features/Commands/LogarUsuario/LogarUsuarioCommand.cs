using MediatR;

namespace VouViajar.Modulos.Usuarios.Application.Features.Commands.LogarUsuario
{
    public class LogarUsuarioCommand : IRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsPersistent { get; set; }
        public bool LockoutOnFailure { get; set; }


}
}
