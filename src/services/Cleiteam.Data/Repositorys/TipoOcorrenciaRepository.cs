using Cleiteam.Data.Context;
using Cleiteam.Domain.Entities;
using Cleiteam.Domain.Interfaces.Repository;

namespace Cleiteam.Data.Repositorys
{
    internal class TipoOcorrenciaRepository : BaseRepository<TipoOcorrencia>, ITipoOcorrenciaRepository
    {
        public TipoOcorrenciaRepository(CleiteamContext context) : base(context)
        {}
    }
}