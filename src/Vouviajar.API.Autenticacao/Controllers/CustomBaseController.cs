using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Linq;
using Vouviajar.API.Autenticacao.Services.Interface;
using Vouviajar.API.Autenticacao.Services.Notificacoes;

namespace Vouviajar.API.Autenticacao.Controllers
{
    [ApiController]
    public abstract class CustomBaseController : ControllerBase
    {
        private readonly INotificador _notificador;

        protected CustomBaseController(INotificador notificador) 
        {
            _notificador = notificador;
        }

        protected ActionResult Retorno(object result = null)
        {
            if (OperacaoValida()) 
            {
                return Ok( new
                    {
                    sucess = true,
                    data = result
                    });
            }

            return BadRequest( new
            {
                sucess = false, 
                errors = _notificador.ObterNotificacoes().Select(n => n.Mensagem)
            }) ;

        }

        protected ActionResult Retorno(ModelStateDictionary modelState)
        {
            if (!modelState.IsValid) NotificarErroModelInvalida(modelState);
            return Retorno();
        }

        protected bool OperacaoValida() => !_notificador.TemNotificacao();

        protected void NotificarErroModelInvalida(ModelStateDictionary modelState)
        {
            var erros = modelState.Values.SelectMany(e => e.Errors);
            foreach (var erro in erros)
            {
                var errorMsg = erro.Exception == null ? erro.ErrorMessage : erro.Exception.Message;
                NotificarErro(errorMsg);
            }
        }

        protected void NotificarErro(string mensagem)
        {
            _notificador.Handle(new Notificacao(mensagem));
        }

    }
}
