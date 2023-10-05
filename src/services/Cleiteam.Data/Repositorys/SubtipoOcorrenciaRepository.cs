using Cleiteam.Data.Context;
using Cleiteam.Domain.Entities;
using Cleiteam.Domain.Interfaces.Repository;

namespace Cleiteam.Data.Repositorys
{
    public class SubtipoOcorrenciaRepository : BaseRepository<SubtipoOcorrencia>, ISubtipoOcorrenciaRepository
    {
        public SubtipoOcorrenciaRepository(CleiteamContext context) : base(context)
        {}
    }
}