using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using VouViajar.Modulos.Eventos.Application.Contracts.Infrastructure;
using VouViajar.Modulos.Eventos.Domain.Entities.Aggregates;

namespace VouViajar.Modulos.Eventos.Application.Features.Commands.CadastrarEvento
{
    public class CadastrarEventoHandler : IRequestHandler<CadastrarEventoCommand>
    {
        public readonly IUnitOfWorkEvento _unitOfWorkEvento;
        
        public CadastrarEventoHandler(IUnitOfWorkEvento unitOfWorkEvento)
        {
            _unitOfWorkEvento = unitOfWorkEvento ?? throw new ArgumentNullException(nameof(unitOfWorkEvento));
        }
        public Task<Unit> Handle(CadastrarEventoCommand request, CancellationToken cancellationToken)
        {
            Evento evento = new Evento
            {
                Nome = request.Nome,
                Resumo = request.Resumo,
                TotalVagas = request.TotalVagas,
                ValorVaga = request.ValorVaga,
                DataInicio = request.DataInicio,
                DataFim = request.DataFim,
                Arquivo = request.Arquivo,
                NomeArquivo = request.NomeArquivo,
                CadastradoEm = DateTime.Now,
                OrigemID = request.Origem, 
                DestinoID = request.Destino,
                TipoID  = request.Tipo.GetHashCode(), 
                SituacaoID = request.Situacao.GetHashCode()
            };

            _unitOfWorkEvento.Context.Evento.Add(evento);
            _unitOfWorkEvento.Save();
            
            return Task.FromResult(Unit.Value);
        }
    }
}
