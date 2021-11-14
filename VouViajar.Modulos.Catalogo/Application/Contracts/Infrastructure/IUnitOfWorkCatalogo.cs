namespace VouViajar.Modulos.Catalogo.Application.Contracts.Infrastructure
{
    public interface IUnitOfWorkCatalogo
    {
        void BeginTransaction();
        void CommitTransaction();
        void Save();
    }
}
