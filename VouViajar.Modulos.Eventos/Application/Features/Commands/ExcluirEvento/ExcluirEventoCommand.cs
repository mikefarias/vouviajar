using MediatR;

namespace VouViajar.Modulos.Eventos.Application.Features.Commands.ExcluirEvento
{
    public class ExcluirEventoCommand : IRequest
    {
        public int ID { get; set; }
    }
}
