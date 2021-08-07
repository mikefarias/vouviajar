using System.Collections.Generic;
using Vouviajar.API.Autenticacao.Services.Notificacoes;

namespace Vouviajar.API.Autenticacao.Services.Interface
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
