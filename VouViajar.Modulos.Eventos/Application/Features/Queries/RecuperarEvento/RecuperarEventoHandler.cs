using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using VouViajar.Modulos.Eventos.Application.Contracts.Infrastructure;

namespace VouViajar.Modulos.Eventos.Application.Features.Queries.RecuperarEvento
{
    public class RecuperarEventoHandler : IRequestHandler<RecuperarEventoQuery, RecuperarEventoResult>
    {
        private readonly IUnitOfWorkEvento _unitOfWorkEvento;

        public RecuperarEventoHandler(IUnitOfWorkEvento unitOfWorkEvento)
        {
            _unitOfWorkEvento = unitOfWorkEvento ?? throw new ArgumentException(null, nameof(unitOfWorkEvento));

        }

        public async Task<RecuperarEventoResult> Handle(RecuperarEventoQuery request, CancellationToken cancellationToken)
        {
            var evento =  _unitOfWorkEvento.EventoRepository.ObterPorId(request.ID);
 
            if (evento is null) throw new InvalidOperationException("Evento não encontrado");

            return new RecuperarEventoResult
            { 
                Nome            = evento.Nome, 
                Resumo          = evento.Resumo, 
                DataInicio      = evento.DataInicio, 
                DataFim         = evento.DataFim, 
                Origem          = evento.Origem is not null ? evento.Origem.ToString() : null, 
                Destino         = evento.Destino is not null ? evento.Destino.ToString() : null,
                ValorVaga       = evento.ValorVaga, 
                TotalVagas      = evento.TotalVagas, 
                Situacao        = evento.Situacao is not null ? evento.Situacao.ToString() : null, 
                Tipo            = evento.Tipo is not null ? evento.Tipo.ToString() : null, 
                NomeArquivo     = evento.NomeArquivo, 
                Arquivo         = evento.Arquivo, 
                CadastradoEm    = evento.CadastradoEm

            }; 
        }
    }
}
