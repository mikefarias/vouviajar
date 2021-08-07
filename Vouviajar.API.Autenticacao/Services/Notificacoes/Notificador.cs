using System.Collections.Generic;
using System.Linq;
using Vouviajar.API.Autenticacao.Services.Interface;

namespace Vouviajar.API.Autenticacao.Services.Notificacoes
{
    public class Notificador : INotificador
    {
        private readonly List<Notificacao> _notificacoes;

        public Notificador()
        {
            _notificacoes = new List<Notificacao>();
        }

        public void Handle(Notificacao notificacao) => _notificacoes.Add(notificacao);

        public List<Notificacao> ObterNotificacoes() => _notificacoes;

        public bool TemNotificacao() => _notificacoes.Any();

    }
}
