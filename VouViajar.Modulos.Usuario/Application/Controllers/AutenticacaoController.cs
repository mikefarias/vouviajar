using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VouViajar.Modulos.Usuarios.Application.Features.Commands.LogarUsuario;
using VouViajar.Modulos.Usuarios.Application.Features.Commands.RegistrarUsuario;
using VouViajar.Modulos.Usuarios.Domain.Services.Interface;
using VouViajar.Modulos.Usuarios.Domain.Services.ViewModel;

namespace VouViajar.Modulos.Usuarios.Application.Controllers
{
    [Route("api/autenticacao")]
    [ApiController]
    public class AutenticacaoController : CustomBaseController
    {

        private readonly IMediator _mediator;

        public AutenticacaoController(INotificador notificador,
                                        IMediator mediator
                                        ) : base(notificador)
        {
            _mediator = mediator;
        }

        [HttpPost("registrar")]
        public async Task<ActionResult> Registrar(RegistrarUsuarioViewModel registrarUsuario)
        {
            if (!ModelState.IsValid) return Retorno(ModelState);

            await _mediator.Send(new RegistrarUsuarioCommand
            {
                UserName = registrarUsuario.Email,
                Email = registrarUsuario.Email,
                EmailConfirmed = true,
                Password = registrarUsuario.Password,
                ConfirmPassword = registrarUsuario.ConfirmPassword
            });

            return Retorno();
        }

        [HttpPost("logar")]
        public async Task<ActionResult> Login(LoginUsuarioViewModel loginUsuario)
        {
            if (!ModelState.IsValid) return Retorno(ModelState);

            await _mediator.Send(new LogarUsuarioCommand
            {
                Email = loginUsuario.Email, 
                Password = loginUsuario.Password, 
                IsPersistent = true, 
                LockoutOnFailure = false
            });

            return Retorno();
        }
    }
}
