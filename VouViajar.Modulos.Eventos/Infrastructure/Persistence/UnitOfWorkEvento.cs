﻿using System;
using VouViajar.Modulos.Eventos.Application.Contracts.Infrastructure;

namespace VouViajar.Modulos.Eventos.Infrastructure.Persistence
{
    public class UnitOfWorkEvento : IUnitOfWorkEvento, IDisposable
    {
        private readonly EventoDbContext _eventoDbContext;

        public EventoDbContext Context { get { return _eventoDbContext; } }
        public UnitOfWorkEvento(EventoDbContext eventoDbContext)
        {
            _eventoDbContext = eventoDbContext;
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