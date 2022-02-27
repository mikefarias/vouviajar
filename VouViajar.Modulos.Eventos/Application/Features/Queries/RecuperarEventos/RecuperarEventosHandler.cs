using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VouViajar.Modulos.Eventos.Application.Contracts.Infrastructure;

namespace VouViajar.Modulos.Eventos.Application.Features.Queries.RecuperarEventos
{
    public class RecuperarEventosHandler : IRequestHandler<RecuperarEventosQuery, List<RecuperarEventosResult>>
    {
        private readonly IUnitOfWorkEvento _unitOfWorkEvento;

        public RecuperarEventosHandler(IUnitOfWorkEvento unitOfWorkEvento)
        {
            _unitOfWorkEvento = unitOfWorkEvento ?? throw new ArgumentException(null, nameof(unitOfWorkEvento));

        }

        public async Task<List<RecuperarEventosResult>> Handle(RecuperarEventosQuery request, CancellationToken cancellationToken)
        {
            var eventos = _unitOfWorkEvento.EventoRepository.ObterTodos();

            if (eventos is null) throw new InvalidOperationException("Evento não encontrado");

            return (eventos.Select(evento => new RecuperarEventosResult
            {
                Nome = evento.Nome,
                Resumo = evento.Resumo,
                DataInicio = evento.DataInicio,
                DataFim = evento.DataFim,
                Origem = evento.Origem is not null ? evento.Origem.ToString() : null,
                Destino = evento.Destino is not null ? evento.Destino.ToString() : null,
                ValorVaga = evento.ValorVaga,
                TotalVagas = evento.TotalVagas,
                Situacao = evento.Situacao is not null ? evento.Situacao.ToString() : null,
                Tipo = evento.Tipo is not null ? evento.Tipo.ToString() : null,
                NomeArquivo = evento.NomeArquivo,
                Arquivo = evento.Arquivo,
                CadastradoEm = evento.CadastradoEm

            })).ToList();
        }
    }
}
