using MediatR;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;
using VouViajar.Modulos.Eventos.Application.Features.Commands.CadastrarEvento;
using VouViajar.Modulos.Eventos.Application.Models;

namespace VouViajar.Modulos.Eventos.Application.Controllers
{

    [Route("api/evento")]
    [ApiController]
    public class EventoController : ControllerBase
    {

        private readonly IMediator _mediator;
        public EventoController(IMediator mediator)
        {
            _mediator = mediator;
        }


        /// <summary>
        /// Realiza a contratação de um produto disponível.
        /// </summary>
        /// <response code="201">Produto contratado.</response>
        /// <response code="400">
        /// Cpf informado na URL é diferente do está sendo informado na requisição.
        /// Erro na contratação do produtos.
        /// </response>
        /// <response code="404">
        /// Parceiro não encontrado ou não identificado.
        /// Cliente não encontrado ou não identificado.
        /// </response>
        /// <returns></returns>
        [HttpPost()]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public async Task<IActionResult> CadastrarEvento([FromBody] CadastrarEventoModel cadastrarEventoModel)
        {
            var cadastrarEventoCommand = new CadastrarEventoCommand
            (
            );

            await _mediator.Send(cadastrarEventoCommand);
            return Created(Request.GetDisplayUrl(), cadastrarEventoModel);
        }

        [HttpPut]
        public ActionResult AtualizarEventoCatalogo()
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public ActionResult ExcluirEventoCatalogo()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public ActionResult ObterEventoCatalogo()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public ActionResult ObterTodosEventosCatalogo()
        {
            throw new NotImplementedException();
        }
    }
}
