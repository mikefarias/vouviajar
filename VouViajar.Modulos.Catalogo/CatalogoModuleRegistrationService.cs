
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using VouViajar.Modulos.Catalogo.Application.Behaviours;

namespace VouViajar.Modulos.Catalogo
{
    public static class CatalogoModuleRegistrationService
    {

        public static IServiceCollection AddCatalogoModuleRegistrationService(this IServiceCollection services, IConfiguration configuration)
        {
            #region MediatR
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            #endregion

            #region Injections
            //services.AddDbContext<OnboardingDbContext>(options => options.UseSqlServer(configuration["OnboardingModule:ConnectionStrings:SQLDataBaseOnboarding"]));

            //services.AddScoped<NotImplExceptionFilterAttribute>();

            //services.AddScoped<IUnitOfWorkOnboarding, UnitOfWorkOnboarding>();
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
