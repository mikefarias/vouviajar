using FluentValidation;

namespace VouViajar.Modulos.Usuarios.Application.Features.Commands.LogarUsuario
{
    public class LogarUsuarioValidator : AbstractValidator<LogarUsuarioCommand>
    {
        public LogarUsuarioValidator()
        {
        }
    }
}
