using MediatR;
using System.Collections.Generic;

namespace VouViajar.Modulos.Eventos.Application.Features.Queries.RecuperarEventos
{
    public class RecuperarEventosQuery : IRequest<List<RecuperarEventosResult>>
    {
        public RecuperarEventosQuery()
        {
        }

        public int ID { get; set; }

    }
}
