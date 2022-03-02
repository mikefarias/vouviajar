using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace VouViajar.Modulos.Usuarios.Infrastructure.Persistence
{
    public class UsuarioDbContext : IdentityDbContext
    {
        public UsuarioDbContext(DbContextOptions<UsuarioDbContext> options) : base(options) { }
    }
}
