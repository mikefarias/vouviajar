using Microsoft.Extensions.DependencyInjection;
using System;
using Vouviajar.API.Autenticacao.IoC;

namespace Vouviajar.API.Autenticacao
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            NativeInjectorBootStrapper.RegisterServices(services);
        }
    }
}
