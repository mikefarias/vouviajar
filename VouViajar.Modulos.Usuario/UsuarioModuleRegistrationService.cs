using MassTransit;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using VouViajar.Modulos.Usuarios.Application.Behaviours;
using VouViajar.Modulos.Usuarios.Infrastructure.Persistence;

namespace VouViajar.Modulos.Usuarios
{
    public static class UsuarioModuleRegistrationService
    {

        public static IServiceCollection AddUsuarioModuleRegistrationService(this IServiceCollection services, IConfiguration configuration)
        {
            #region MediatR

            var assembly = AppDomain.CurrentDomain.Load("VouViajar.Modulos.Usuarios");
            services.AddValidatorsFromAssembly(assembly);
            services.AddMediator(); // Utilizar o MeditatR
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            #endregion

            #region Injections
            services.AddDbContext<UsuarioDbContext>(options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=vouviajar;Integrated Security=True"));

            //services.AddScoped<IUnitOfWorkEvento, UnitOfWorkEvento>();

            #endregion

            return services;
        }
    }
}
