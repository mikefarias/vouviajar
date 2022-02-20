using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;
using VouViajar.Modulos.Eventos.Application.Behaviours;
using VouViajar.Modulos.Eventos.Application.Contracts.Infrastructure;
using VouViajar.Modulos.Eventos.Application.Features.Commands.CadastrarEvento;
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

            //#region RabbitMQ
            //var eventBusHostAddress = configuration["WebhookModule:EventBusSettings:HostAddress"];
            //var eventBusHostQueue = configuration["WebhookModule:EventBusSettings:Queue"];
            //if (eventBusHostAddress is not null && eventBusHostQueue is not null)
            //{
            //    services.AddMassTransit(config =>
            //    {
            //        config.AddConsumer<SeacLegadoQueue>();
            //        config.UsingRabbitMq((ctx, cfg) =>
            //        {
            //            cfg.Host(eventBusHostAddress);

            //            cfg.ReceiveEndpoint(eventBusHostQueue, c =>
            //            {
            //                c.ConfigureConsumer<SeacLegadoQueue>(ctx);
            //                c.UseMessageRetry(r =>
            //                {
            //                    r.Interval(10, TimeSpan.FromSeconds(1));
            //                    r.Ignore<ArgumentNullException>();
            //                });
            //            });
            //        });
            //        config.AddTransactionalBus();

            //    });
            //    services.AddMassTransitHostedService();
            //}
            //#endregion

            return services;
        }
    }
}
