using MediatR;

namespace VouViajar.Modulos.Eventos.Application.Features.Queries.RecuperarEvento
{
    public class RecuperarEventoQuery : IRequest<RecuperarEventoResult>
    {
        public RecuperarEventoQuery()
        {
        }

        public int ID { get; set; }

    }
}
