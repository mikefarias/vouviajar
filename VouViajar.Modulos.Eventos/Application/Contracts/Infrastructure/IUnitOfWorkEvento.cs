using VouViajar.Modulos.Eventos.Infrastructure.Persistence;

namespace VouViajar.Modulos.Eventos.Application.Contracts.Infrastructure
{
    public interface IUnitOfWorkEvento
    {
        EventoDbContext Context { get; }
        void BeginTransaction();
        void CommitTransaction();
        void Save();
    }
}
