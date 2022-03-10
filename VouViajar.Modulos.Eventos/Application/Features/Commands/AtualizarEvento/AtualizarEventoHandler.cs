using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using VouViajar.Modulos.Eventos.Application.Contracts.Infrastructure;

namespace VouViajar.Modulos.Eventos.Application.Features.Commands.AtualizarEvento
{
    public class AtualizarEventoHandler : IRequestHandler<AtualizarEventoCommand>
    {
        public readonly IUnitOfWorkEvento _unitOfWorkEvento;

        public AtualizarEventoHandler(IUnitOfWorkEvento unitOfWorkEvento)
        {
            _unitOfWorkEvento = unitOfWorkEvento ?? throw new ArgumentNullException(nameof(unitOfWorkEvento));
        }
        public Task<Unit> Handle(AtualizarEventoCommand request, CancellationToken cancellationToken)
        {

            var evento = _unitOfWorkEvento.EventoRepository.ObterPorId(request.ID);

            if (evento is null) throw new InvalidOperationException("Evento não encontrado");

            evento.Nome = request.Nome;
            evento.Resumo = request.Resumo;
            evento.TotalVagas = request.TotalVagas;
            evento.ValorVaga = request.ValorVaga;
            evento.DataInicio = request.DataInicio;
            evento.DataFim = request.DataFim;
            evento.Arquivo = request.Arquivo;
            evento.NomeArquivo = request.NomeArquivo;
            evento.CadastradoEm = DateTime.Now;
            evento.OrigemID = request.Origem;
            evento.DestinoID = request.Destino;
            evento.TipoID = request.Tipo.GetHashCode();
            evento.SituacaoID = request.Situacao.GetHashCode();

            _unitOfWorkEvento.EventoRepository.Salvar(evento);
            _unitOfWorkEvento.Save();

            return Task.FromResult(Unit.Value);
        }
    }
}
