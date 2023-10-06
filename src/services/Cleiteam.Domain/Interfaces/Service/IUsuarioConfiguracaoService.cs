using Cleiteam.Domain.Models;

namespace Cleiteam.Domain.Interfaces.Service
{
    public interface IUsuarioConfiguracaoService
    {
        Task<UsuarioView> ObterDadosUsuario();
        Task Editar(UsuarioView model);
    }
}