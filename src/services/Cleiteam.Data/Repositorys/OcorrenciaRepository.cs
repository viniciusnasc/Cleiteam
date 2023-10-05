using Cleiteam.Data.Context;
using Cleiteam.Domain.Entities;
using Cleiteam.Domain.Interfaces.Repository;

namespace Cleiteam.Data.Repositorys
{
    internal class OcorrenciaRepository : BaseRepository<Ocorrencia>, IOcorrenciaRepository
    {
        public OcorrenciaRepository(CleiteamContext context) : base(context)
        {}
    }
}
