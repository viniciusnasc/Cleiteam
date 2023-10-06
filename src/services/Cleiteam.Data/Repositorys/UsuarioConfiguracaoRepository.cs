using Cleiteam.Data.Context;
using Cleiteam.Domain.Entities;
using Cleiteam.Domain.Interfaces.Repository;

namespace Cleiteam.Data.Repositorys
{
    internal class UsuarioConfiguracaoRepository : BaseRepository<UsuarioConfiguracao>, IUsuarioConfiguracaoRepository
    {
        public UsuarioConfiguracaoRepository(CleiteamContext context) : base(context)
        {
        }
    }
}