using Cleiteam.Domain.Models;

namespace Cleiteam.Domain.Interfaces.Service
{
    public interface IOcorrenciaService
    {
        Task<List<OcorrenciaViewModel>> Buscar(long latitude, long longitude, int rangeDistancia);
        Task Cadastrar(OcorrenciaInputModel model);
    }
}