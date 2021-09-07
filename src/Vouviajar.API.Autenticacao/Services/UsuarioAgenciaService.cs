using MassTransit;
using System;
using System.Threading;
using System.Threading.Tasks;
using Vouviajar.API.Autenticacao.Entities;

namespace Vouviajar.API.Autenticacao.Services
{
    public class UsuarioAgenciaService
    {
        private readonly IBusControl _bus;

        public UsuarioAgenciaService(IBusControl bus)
        {
            _bus = bus;
        }

        private async Task RegistrarUsuario(Usuario usuario) 
        {
            //AgenciaMessage agenciaMessage = new AgenciaMessage();
            var source = new CancellationTokenSource(TimeSpan.FromSeconds(10));
            var endpoint = await _bus.GetSendEndpoint(new Uri(""));

        }

    }
}
