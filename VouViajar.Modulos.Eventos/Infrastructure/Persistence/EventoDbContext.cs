using Microsoft.EntityFrameworkCore;
using VouViajar.Modulos.Eventos.Domain.Entities;
using VouViajar.Modulos.Eventos.Domain.Entities.Aggregates;

namespace VouViajar.Modulos.Eventos.Infrastructure.Persistence
{
    public partial class EventoDbContext : DbContext
    {
        public EventoDbContext Instance => this;

        public DbSet<Evento> Evento { get; set; }
        public DbSet<Localidade> Localidade { get; set; }
        public DbSet<Situacao> Situacao { get; set; }
        public DbSet<Tipo> Tipo { get; set; }


        public EventoDbContext(DbContextOptions<EventoDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Evento>()
                .HasKey(ev => new {ev.IdEvento});

            builder.Entity<Localidade>()
                .HasKey(ev => new { ev.IdLocalidade});

            builder.Entity<Situacao>()
                .HasKey(ev => new { ev.IdSituacao });

            builder.Entity<Tipo>()
                .HasKey(ev => new { ev.IdTipo });

        }

    }
}
