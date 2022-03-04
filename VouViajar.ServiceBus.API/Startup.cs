using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VouViajar.Modulos.Eventos;
using VouViajar.Modulos.Usuarios;
using VouViajar.Modulos.Usuarios.Domain.Services.AutoMapper;
using VouViajar.ServiceBusAPI.Extensions;

namespace VouViajar.ServiceBus.API
{
    public class Startup
    {

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEventoModuleRegistrationService(Configuration);

            services.AddUsuarioModuleRegistrationService(Configuration);

            services.AddHttpClient();

            services.AddAutoMapper(typeof(ConfigurationMapper));

            #region Swagger
            services.AddControllers()
                .AddFluentValidation(config => config.RegisterValidatorsFromAssemblyContaining<Startup>())
                .AddCustomJsonOptions()
                .ConfigureApiBehaviorOptions(options =>
                {
                    options.SuppressModelStateInvalidFilter = true;
                });
            services.AddSwaggerGen(c =>
                c.SwaggerDoc(name: "v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Vou Viajar", Version = "v1" })
            );
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });

            #endregion
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
         
            app.UseForwardedHeaders();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint(url: "/swagger/v1/swagger.json", name: "Vou Viajar");
                    c.RoutePrefix = string.Empty;
                }
                );
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}