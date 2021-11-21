namespace VouViajar.Modulos.Eventos.Application.Contracts.Services
{
    public interface IEventoService
    {
        void CadastrarEvento(Domain.Entities.Aggregates.Evento evento);
    }
}
