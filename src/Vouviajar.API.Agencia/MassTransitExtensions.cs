using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Seac.Onboarding.Util.Extensions;
using System;
using Vouviajar.API.Agencia.Consumers;
using Vouviajar.API.Core;

namespace Vouviajar.API.Agencia.Extensions
{
    /// <summary>
    /// Extensões do MassTransit
    /// </summary>
    public static class MassTransitExtension
    {
        /// <summary>
        /// Configuração básica do MassTransit
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static IServiceCollection AddCustomMassTransit(this IServiceCollection services, IConfiguration configuration)
        {
            var RABBITMQ_USERNAME = EnvironmentExtension.GetEnvironmentVariable("RABBITMQ_USERNAME");
            var RABBITMQ_PASSWORD = EnvironmentExtension.GetEnvironmentVariable("RABBITMQ_PASSWORD");

            var connectionStringRabbitMQ = configuration.GetConnectionString("RabbitMQ");
            var virtualHostRabbitMQ = configuration.GetSection("MessageBrokerConfig:VirtualHost").Value;
            var portRabbitMQ = Convert.ToUInt16(configuration.GetSection("MessageBrokerConfig:Port").Value);
            var cadastrarAgenciaEndpoint = configuration.GetSection("MessageBrokerConfig:Endpoints:NovaAgencia").Value;

            services.AddMassTransit(bus =>
            {
                bus.AddConsumer<CadastrarAgenciaConsumer>();

                bus.UsingRabbitMq((ctx, busConfigurator) =>
                {
                    busConfigurator.Host("amqp://guest:guest@localhost:5672");

                    busConfigurator.ReceiveEndpoint(cadastrarAgenciaEndpoint, e =>
                    {
                        e.ConfigureConsumer<CadastrarAgenciaConsumer>(ctx);
                    });
                });


            });
            
            services.AddMassTransitHostedService();
            return services;
        }
    }
}