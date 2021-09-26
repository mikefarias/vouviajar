using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vouviajar.API.Core;

namespace Vouviajar.API.Agencia.Consumers
{
    public class CadastrarAgenciaConsumer : IConsumer<AgenciaMessage>
    {
        public Task Consume(ConsumeContext<AgenciaMessage> context)
        {
            return Task.CompletedTask;
        }
    }
}
