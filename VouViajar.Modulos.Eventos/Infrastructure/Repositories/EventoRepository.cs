using VouViajar.Modulos.Eventos.Application.Contracts.Infrastructure;

namespace VouViajar.Modulos.Eventos.Infrastructure.Repositories
{
    public class EventoRepository: BaseRepository<Domain.Entities.Aggregates.Evento>, IEventoRepository
    { 
    }
}
