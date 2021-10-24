namespace VouViajar.Modulos.Catalogo.Application.Contracts.Infrastructure
{
    public interface IUnitOfWorkCatalogo
    {
        //ITbDadosContratantePropostaRepository TbDadosContratantePropostaRepository { get; }
        void BeginTransaction();
        void CommitTransaction();
        void Save();
    }
}
