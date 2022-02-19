using MediatR;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;
using VouViajar.Modulos.Eventos.Application.Features.Commands.CadastrarEvento;
using VouViajar.Modulos.Eventos.Application.Models;
using VouViajar.Modulos.Eventos.Domain.Enums;

namespace VouViajar.Modulos.Eventos.Application.Controllers
{

    [Route("api/evento")]
    [ApiController]
    public class EventoController : ControllerBase
    {

        private readonly IMediator _mediator;
        public EventoController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
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
            var cadastrarEventoCommand = new CadastrarEventoCommand()
            {
                Nome        = cadastrarEventoModel.Nome,
                Resumo      = cadastrarEventoModel.Resumo, 
                DataInicio  = cadastrarEventoModel.DataInicio, 
                DataFim     = cadastrarEventoModel.DataFim, 
                Origem      = cadastrarEventoModel.Origem, 
                Destino     = cadastrarEventoModel.Destino, 
                NomeArquivo = cadastrarEventoModel.NomeArquivo, 
                Arquivo     = cadastrarEventoModel.Arquivo, 
                TotalVagas  = cadastrarEventoModel.TotalVagas, 
                ValorVaga   = cadastrarEventoModel.ValorVaga, 
                Tipo        = cadastrarEventoModel.Tipo, 
                Situacao    = EnumSituacaoEvento.CADASTRADO

            };

            await _mediator.Send(cadastrarEventoCommand);
            return Created(Request.GetDisplayUrl(), cadastrarEventoModel);
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [HttpPut]
        public ActionResult AtualizarEvento()
        {
            throw new NotImplementedException();
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [HttpDelete]
        public ActionResult ExcluirEvento()
        {
            throw new NotImplementedException();
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [HttpGet("{id}")]
        public ActionResult ObterEvento()
        {
            throw new NotImplementedException();
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [HttpGet]
        public ActionResult ObterEventos()
        {
            throw new NotImplementedException();
        }
    }
}
