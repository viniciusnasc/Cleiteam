using Cleiteam.Domain.Entities;

namespace Cleiteam.Domain.Interfaces.Service
{
    public interface IUsuarioOcorrenciaService
    {
        Task Cadastrar(Guid idOcorrencia);
        Task<IEnumerable<UsuarioOcorrencia>> BuscarTodos();
    }
}