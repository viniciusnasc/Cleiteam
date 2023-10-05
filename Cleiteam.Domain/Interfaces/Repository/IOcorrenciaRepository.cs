using Cleiteam.Domain.Entities;

namespace Cleiteam.Domain.Interfaces.Repository
{
    public interface IOcorrenciaRepository : IBaseRepository<Ocorrencia>
    {
        Task<List<Ocorrencia>> BuscarVarios(long latitude, long longitude, int rangeDistancia);
    }
}