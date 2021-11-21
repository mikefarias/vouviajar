using VouViajar.Modulos.Eventos.Application.Contracts.Infrastructure;
using VouViajar.Modulos.Eventos.Domain.Entities.Aggregates;

namespace VouViajar.Modulos.Eventos.Infrastructure.Repositories
{
    public class EventoRepository: BaseRepository<Evento>, IEventoRepository
    { 
    }
}
