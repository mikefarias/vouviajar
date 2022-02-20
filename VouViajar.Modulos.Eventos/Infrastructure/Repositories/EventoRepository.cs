using VouViajar.Modulos.Eventos.Application.Contracts.Infrastructure;
using VouViajar.Modulos.Eventos.Domain.Entities.Aggregates;
using VouViajar.Modulos.Eventos.Infrastructure.Persistence;

namespace VouViajar.Modulos.Eventos.Infrastructure.Repositories
{
    public class EventoRepository: BaseRepository<Evento>, IEventoRepository
    {
        public EventoRepository(EventoDbContext context) : base(context) 
        { 
        }
    }
}
