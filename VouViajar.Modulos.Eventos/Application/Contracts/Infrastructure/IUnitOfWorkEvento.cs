namespace VouViajar.Modulos.Eventos.Application.Contracts.Infrastructure
{
    public interface IUnitOfWorkEvento
    {
        void BeginTransaction();
        void CommitTransaction();
        void Save();
    }
}
