using Cleiteam.Domain.Models;

namespace Cleiteam.Domain.Interfaces.Service
{
    public interface IComentarioService
    {
        Task Comentar(ComentarioInputModel model);
        Task<List<ComentarioView>> BuscarTodos(Guid idImagem);
        Task Editar(ComentarioEditModel model);
        Task Deletar(Guid idComentario);
    }
}