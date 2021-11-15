namespace VouViajar.Modulos.Evento.Application.Contracts.Infrastructure
{
    public interface IUnitOfWorkCatalogo
    {
        void BeginTransaction();
        void CommitTransaction();
        void Save();
    }
}
