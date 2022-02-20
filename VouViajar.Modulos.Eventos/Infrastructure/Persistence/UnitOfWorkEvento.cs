using System;
using VouViajar.Modulos.Eventos.Application.Contracts.Infrastructure;
using VouViajar.Modulos.Eventos.Infrastructure.Repositories;

namespace VouViajar.Modulos.Eventos.Infrastructure.Persistence
{
    public class UnitOfWorkEvento : IUnitOfWorkEvento, IDisposable
    {
        private readonly EventoDbContext _eventoDbContext;

        public EventoDbContext Context { get { return _eventoDbContext; } }

        private readonly IEventoRepository _eventoRepository;
        public IEventoRepository EventoRepository { get { return _eventoRepository; } }

        public UnitOfWorkEvento(EventoDbContext eventoDbContext,
                                IEventoRepository eventoRepository)
        {
            _eventoDbContext = eventoDbContext;
            _eventoRepository = eventoRepository;
        }

        public void Save()
        {
            _eventoDbContext.Instance.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed && disposing)
                _eventoDbContext.Instance.Dispose();
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void BeginTransaction()
        {
            _eventoDbContext.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _eventoDbContext.Database.CommitTransaction();
        }
    }
}