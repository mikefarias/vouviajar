﻿using Microsoft.EntityFrameworkCore;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("Eventos");

            modelBuilder.Entity<Evento>()
                .HasKey(ev => new { ev.EventoID });

            modelBuilder.Entity<Evento>().HasOne(ev => ev.Origem).WithOne().OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Evento>().HasOne(ev => ev.Destino).WithOne().OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Evento>().HasOne(ev => ev.Tipo).WithOne().OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Evento>().HasOne(ev => ev.Situacao).WithOne().OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Evento>().Property("ValorVaga").HasColumnType("decimal").HasPrecision(5);

            modelBuilder.Entity<Localidade>()
                .HasKey(ev => new { ev.LocalidadeID });

            modelBuilder.Entity<Situacao>()
                .HasKey(ev => new { ev.SituacaoID });

            modelBuilder.Entity<Tipo>()
                .HasKey(ev => new { ev.TipoID });

        }

    }
}
