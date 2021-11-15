using Microsoft.EntityFrameworkCore;

namespace VouViajar.Modulos.Evento.Infrastructure.Persistence
{
    public partial class EventoDbContext : DbContext
    {
        public EventoDbContext Instance => this;

        //public DbSet<TbDadosContratanteProposta> TbDadosContratanteProposta { get; set; }
        public EventoDbContext()
        {
        }

        public EventoDbContext(DbContextOptions<EventoDbContext> options) : base(options)
        {

        }

    }
}
