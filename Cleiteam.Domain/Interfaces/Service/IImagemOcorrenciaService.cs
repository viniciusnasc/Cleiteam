using Cleiteam.Domain.Models;
using Microsoft.AspNetCore.Http;

namespace Cleiteam.Domain.Interfaces.Service
{
    public interface IImagemOcorrenciaService
    {
        Task<List<ImagemView>> BuscarTodos(Guid idOcorrencia);
        Task Adicionar(Guid idOcorrencia, IFormFile file);
        Task Deletar(Guid idImagem);
    }
}