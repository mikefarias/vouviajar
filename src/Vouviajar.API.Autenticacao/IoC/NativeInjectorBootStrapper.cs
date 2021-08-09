using Microsoft.Extensions.DependencyInjection;
using Vouviajar.API.Autenticacao.Services.Interface;
using Vouviajar.API.Autenticacao.Services.Notificacoes;

namespace Vouviajar.API.Autenticacao.IoC
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