using MediatR;

namespace VouViajar.Modulos.Usuarios.Application.Features.Commands.RegistrarUsuario
{
    public class RegistrarUsuarioCommand : IRequest
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
