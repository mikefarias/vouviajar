using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using VouViajar.Modulos.Eventos.Application.Contracts.Infrastructure;
using VouViajar.Modulos.Eventos.Application.Features.Commands.ExcluirEvento;

namespace VouViajar.Modulos.Eventos.Application.Features.Commands.ExcluirrEvento
{
    public class ExcluirEventoHandler : IRequestHandler<ExcluirEventoCommand>
    {
        public readonly IUnitOfWorkEvento _unitOfWorkEvento;

        public ExcluirEventoHandler(IUnitOfWorkEvento unitOfWorkEvento)
        {
            _unitOfWorkEvento = unitOfWorkEvento ?? throw new ArgumentNullException(nameof(unitOfWorkEvento));
        }
        public Task<Unit> Handle(ExcluirEventoCommand request, CancellationToken cancellationToken)
        {

            var evento = _unitOfWorkEvento.EventoRepository.ObterPorId(request.ID);

            if (evento is null) throw new InvalidOperationException("Evento não encontrado");

            _unitOfWorkEvento.EventoRepository.Excluir(evento);
            _unitOfWorkEvento.Save();

            return Task.FromResult(Unit.Value);
        }
    }
}
