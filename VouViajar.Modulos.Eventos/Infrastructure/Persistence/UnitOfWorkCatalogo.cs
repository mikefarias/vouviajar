using System;
using VouViajar.Modulos.Eventos.Application.Contracts.Infrastructure;

namespace VouViajar.Modulos.Eventos.Infrastructure.Persistence
{
    public class UnitOfWorkEvento : IUnitOfWorkEvento, IDisposable
    {
        private readonly EventoDbContext _catalogoDbContext;

        public UnitOfWorkEvento() { }

        public UnitOfWorkEvento(
                EventoDbContext catalogoDbContext)
        {
            _catalogoDbContext = catalogoDbContext;
        }

        public void Save()
        {
            _catalogoDbContext.Instance.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed && disposing)
                _catalogoDbContext.Instance.Dispose();
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void BeginTransaction()
        {
            _catalogoDbContext.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _catalogoDbContext.Database.CommitTransaction();
        }
    }

}
