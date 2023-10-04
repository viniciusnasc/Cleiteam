using Cleiteam.Domain.NotificadorErros;

namespace Cleiteam.Domain.Interfaces.Service
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}