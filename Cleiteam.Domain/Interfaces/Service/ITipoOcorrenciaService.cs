using Cleiteam.Domain.Models;

namespace Cleiteam.Domain.Interfaces.Service
{
    public interface ITipoOcorrenciaService
    {
        Task Adicionar(string descricao);
        Task<IEnumerable<TipoOcorrenciaView>> BuscarTodos();
    }
}