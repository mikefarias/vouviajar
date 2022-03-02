using Microsoft.Extensions.DependencyInjection;
using VouViajar.Modulos.Usuarios.Domain.Services.Interface;
using VouViajar.Modulos.Usuarios.Domain.Services.Notificacoes;

namespace VouViajar.Modulos.Usuarios.Application.Extensions
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<INotificador, Notificador>();

            services.AddMemoryCache();

        }
    }
}