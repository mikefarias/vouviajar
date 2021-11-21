using Microsoft.EntityFrameworkCore;
using VouViajar.Modulos.Eventos.Domain.Entities.Aggregates;

namespace VouViajar.Modulos.Eventos.Infrastructure.Persistence
{
    public partial class EventoDbContext : DbContext
    {
        public EventoDbContext Instance => this;

        public DbSet<Evento> Evento { get; set; }
        public EventoDbContext()
        {
        }

        public EventoDbContext(DbContextOptions<EventoDbContext> options) : base(options)
        {

        }

    }
}
