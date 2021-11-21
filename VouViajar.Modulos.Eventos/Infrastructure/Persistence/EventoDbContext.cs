using Microsoft.EntityFrameworkCore;

namespace VouViajar.Modulos.Eventos.Infrastructure.Persistence
{
    public partial class EventoDbContext : DbContext
    {
        public EventoDbContext Instance => this;

        public DbSet<Domain.Entities.Aggregates.Evento> Evento { get; set; }
        public EventoDbContext()
        {
        }

        public EventoDbContext(DbContextOptions<EventoDbContext> options) : base(options)
        {

        }

    }
}
