using MassTransit;
using Microsoft.Extensions.Options;
using Service.Services;
using System;
using System.Threading;
using System.Threading.Tasks;
using Vouviajar.API.Autenticacao.Entities;
using Vouviajar.API.Autenticacao.Services.Config;
using Vouviajar.API.Autenticacao.Services.Interface;
using Vouviajar.API.Autenticacao.Services.Interfaces;
using Vouviajar.API.Core;

namespace Vouviajar.API.Autenticacao.Services
{
    public class UsuarioAgenciaService : BaseService, IUsuarioAgenciaService
    {
        private readonly IOptions<MessageBrokerConfig> _messageBrokerConfig;
        private readonly IBusControl _bus;
        private readonly INotificador _notificador;
        private readonly Uri URI_NOVA_AGENCIA;

        public UsuarioAgenciaService(IOptions<MessageBrokerConfig> messageBrokerConfig,
                                        IBusControl bus, INotificador notificador) : base (notificador)
        {
            _messageBrokerConfig = messageBrokerConfig;
             _bus = bus;
            _notificador = notificador;
            URI_NOVA_AGENCIA = new Uri($"{_messageBrokerConfig.Value.Endpoints.PrefixQueue}{_messageBrokerConfig.Value.Endpoints.NovaAgencia}");
        }

        public async Task<ResponseService> RegistrarAgencia(Usuario usuario)
        {
            AgenciaMessage agencia = new AgenciaMessage(usuario.Id, usuario.Email);
            var source = new CancellationTokenSource(TimeSpan.FromSeconds(10));
            var endpoint = await _bus.GetSendEndpoint(URI_NOVA_AGENCIA);
            await endpoint.Send<AgenciaMessage>(usuario, source.Token);
            return await GenerateSuccessServiceResponse();
        }
    }
}
