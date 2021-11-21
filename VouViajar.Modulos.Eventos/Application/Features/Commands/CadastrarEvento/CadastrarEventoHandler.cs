using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using VouViajar.Modulos.Eventos.Application.Contracts.Infrastructure;

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
            throw new System.NotImplementedException();
        }
    }
}
