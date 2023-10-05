using Microsoft.AspNetCore.Http;

namespace Cleiteam.Domain.Interfaces.Service
{
    public interface IImagemOcorrenciaService
    {
        Task Adicionar(Guid idOcorrencia, IFormFile file);
        Task Deletar(Guid idImagem);
    }
}