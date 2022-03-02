using System.Collections.Generic;
using VouViajar.Modulos.Usuarios.Domain.Services.Notificacoes;

namespace VouViajar.Modulos.Usuarios.Domain.Services.Interface
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
