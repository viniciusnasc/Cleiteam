using Cleiteam.Data.Context;
using Cleiteam.Domain.Interfaces.Repository;

namespace Cleiteam.Data.Repositorys
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CleiteamContext _context;
        public ITipoOcorrenciaRepository TipoOcorrenciaRepository { get; }

        public UnitOfWork(CleiteamContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            TipoOcorrenciaRepository = new TipoOcorrenciaRepository(context);
        }
    }
}