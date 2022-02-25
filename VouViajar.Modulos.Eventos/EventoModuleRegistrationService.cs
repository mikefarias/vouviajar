using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using VouViajar.Modulos.Eventos.Application.Behaviours;
using VouViajar.Modulos.Eventos.Application.Contracts.Infrastructure;
using VouViajar.Modulos.Eventos.Infrastructure.Persistence;
using VouViajar.Modulos.Eventos.Infrastructure.Repositories;

namespace VouViajar.Modulos.Eventos
{
    public static class EventoModuleRegistrationService
    {

        public static IServiceCollection AddEventoModuleRegistrationService(this IServiceCollection services, IConfiguration configuration)
        {
            #region MediatR

            var assembly = AppDomain.CurrentDomain.Load("VouViajar.Modulos.Eventos");
            services.AddValidatorsFromAssembly(assembly);
            services.AddMediatR(assembly);
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            #endregion

            #region Injections
            services.AddDbContext<EventoDbContext>(options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=vouviajar;Integrated Security=True"));

            services.AddScoped<IUnitOfWorkEvento, UnitOfWorkEvento>();
            services.AddScoped<IEventoRepository, EventoRepository>();

            #endregion

            return services;
        }
    }
}
