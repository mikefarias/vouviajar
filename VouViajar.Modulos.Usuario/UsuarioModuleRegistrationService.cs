using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using VouViajar.Modulos.Usuarios.Application.Behaviours;
using VouViajar.Modulos.Usuarios.Domain.Services.Interface;
using VouViajar.Modulos.Usuarios.Domain.Services.Notificacoes;
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
            services.AddMediatR(assembly);
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            #endregion

            #region Injections
            services.AddDbContext<UsuarioDbContext>(options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=vouviajar;Integrated Security=True"));

            services.AddScoped<INotificador, Notificador>();
            #endregion

            return services;
        }
    }
}
