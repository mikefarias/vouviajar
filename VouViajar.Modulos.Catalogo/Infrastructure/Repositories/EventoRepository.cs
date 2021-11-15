using VouViajar.Modulos.Catalogo.Application.Contracts.Infrastructure;
using VouViajar.Modulos.Catalogo.Domain.Entities.Aggregates;

namespace VouViajar.Modulos.Catalogo.Infrastructure.Repositories
{
    public class EventoRepository: BaseRepository<Evento>, IEventoRepository
    { 
    }
}
