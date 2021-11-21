using VouViajar.Modulos.Eventos.Domain.Entities.Aggregates;

namespace VouViajar.Modulos.Eventos.Application.Contracts.Services
{
    public interface IEventoService
    {
        void CadastrarEvento(Evento evento);
    }
}
