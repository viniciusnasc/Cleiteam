using Cleiteam.Data.Context;
using Cleiteam.Domain.Entities;
using Cleiteam.Domain.Interfaces.Repository;

namespace Cleiteam.Data.Repositorys
{
    internal class UsuarioOcorrenciaRepository : BaseRepository<UsuarioOcorrencia>, IUsuarioOcorrenciaRepository
    {
        public UsuarioOcorrenciaRepository(CleiteamContext context) : base(context)
        {
        }
    }
}
