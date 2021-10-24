using Microsoft.EntityFrameworkCore;

namespace VouViajar.Modulos.Catalogo.Infrastructure.Persistence
{
    public partial class CatalogoDbContext : DbContext
    {
        public CatalogoDbContext Instance => this;

        //public DbSet<TbDadosContratanteProposta> TbDadosContratanteProposta { get; set; }
        public CatalogoDbContext()
        {
        }

        public CatalogoDbContext(DbContextOptions<CatalogoDbContext> options) : base(options)
        {

        }

    }
}
